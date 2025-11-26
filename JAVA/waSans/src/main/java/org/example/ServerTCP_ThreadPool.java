package org.example;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.PrintStream;
import java.net.InetSocketAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.SocketException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Scanner;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class ServerTCP_ThreadPool {
	private static ServerSocket serverSocket = null;
	private static ExecutorService executorService = Executors.newFixedThreadPool(20);
    private static JSONArray jsonArr;
    private static Connection conn;

    // [ - main - ]
	public static void main(String[] args) throws Exception {
        System.setOut(new PrintStream(System.out, true, "UTF-8"));
		System.out.println("--------------------------------------------------------------------");
		System.out.println("서버 종료 : 'stop' 입력");
		System.out.println("--------------------------------------------------------------------");

        DBconn(); // DB 연결
		startServer(); // 서버 시작

		Scanner sc = new Scanner(System.in);
		while(true) {
			String key = sc.nextLine();
			if(key.equals("stop")) break; // 종료
		}
		sc.close();

		stopServer(); // 서버 종료
	}

    // [ DB 생성/연결 ]
    public static void DBconn() throws Exception {
        conn = DriverManager.getConnection("jdbc:sqlite:sans.db");
        conn.createStatement().execute(
                "CREATE TABLE sans_write (" +
                        "s_id INTEGER," +
                        "s_title TEXT NOT NULL," +
                        "s_author TEXT NOT NULL," +
                        "s_content TEXT NOT NULL," +
                        "PRIMARY KEY(s_id AUTOINCREMENT));"
        );
    }

    // [ DB INSERT ]
    public static void DBaddRow() {
        // 더미데이터 생성
        jsonArr = new JSONArray();
        for (int i = 0; i < 5; i++) {
            JSONObject row = new JSONObject();
            row.put("id", i);
            row.put("title", i+"줴목"+i);
            row.put("author", i+"누군가"+i);
            row.put("content", "이거"+i+"슨 내용");
            jsonArr.put(row);
        }
    }

    // [ start Server ]
	public static void startServer() {
		//작업 스레드 정의
		Thread thread = new Thread(() -> {
            try {
                //ServerSocket 생성 및 Port 바인딩
                serverSocket = new ServerSocket(50001);
                System.out.println( "[서버] 시작됨");

                // 연결 수락 및 데이터 통신
                while(true) {
                    // 클라이언트 대기
                    Socket socket = serverSocket.accept();
                    //연결된 클라이언트 주소(이름?) 얻기
                    String clientName = ((InetSocketAddress) socket.getRemoteSocketAddress()).getHostName();

                    // 스레드풀에 있는 스레드가 실행?
                    executorService.execute(() -> {
                        try {
                            System.out.println("\n[서버] 연결(" + clientName + ")");

                            // 데이터 받기
                            DataInputStream dis = new DataInputStream(socket.getInputStream());
                            String reqData = dis.readUTF();
                            JSONObject reqJson = new JSONObject(reqData);
                            System.out.println( "[서버] 받음("+clientName+"): " + reqData);

                            // 요청 처리
                            String resData=null;
                            switch (reqJson.getString("command")) {
                                case "save_and_all": // 저장 및 전체조회
                                    jsonArr.put(reqJson.getJSONObject("obj"));
                                case "all": // 전체조회
                                    JSONArray jsonResArr = new JSONArray();
                                    for (int i=0; i<jsonArr.length();i++) {
                                        JSONObject tmp = new JSONObject();
                                        tmp.put("id", jsonArr.getJSONObject(i).get("id"));
                                        tmp.put("title", jsonArr.getJSONObject(i).getString("title"));
                                        jsonResArr.put(tmp);
                                    }
                                    resData = jsonResArr.toString();
                                    break;
                                case "one": // 하나 상세조회
                                    int id = reqJson.getInt("id");
                                    resData = jsonArr.getJSONObject(id).toString();
                                    break;
                            }

                            // 데이터 보내기
                            DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
                            dos.writeUTF(resData);
                            dos.flush();
                            System.out.println( "[서버] 전송("+clientName+"): " + resData);

                            //연결 끊기
                            socket.close();
                            System.out.println("[서버] 연결끊음(" + clientName + ")");
                        } catch(IOException e) {System.out.println(e.getMessage());}
                    });
                }
            } catch (SocketException e1) {}
            catch(IOException e) { e.printStackTrace(); }
        });
        //스레드 시작
		thread.start();
	}

    // [ stop Server ]
	public static void stopServer() {
		try {
			//ServerSocket을 닫고 Port 언바인딩
			serverSocket.close();
			executorService.shutdownNow();
			System.out.println( "[서버] 종료됨 ");
		} catch (IOException e1) {}
	}
}


