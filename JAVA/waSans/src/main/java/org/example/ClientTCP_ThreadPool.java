package org.example;

import org.json.JSONObject;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.PrintStream;
import java.net.Socket;
import java.util.Scanner;

public class ClientTCP_ThreadPool {

    private static Socket socket;
	public static void main(String[] args) {
		try {
            System.setOut(new PrintStream(System.out, true, "UTF-8"));
            boolean tri = true;
            while (tri) {
                boolean isData = true;
                // 입력받기
                Scanner sc = new Scanner(System.in);
                System.out.println("---------------");
                System.out.print("1 : all / 2: one / 3: save_and_all / 4: 종료\n-> ");
                String in = sc.nextLine();
                System.out.println("---------------");

                // 보낼 데이터 생성
                JSONObject row = new JSONObject();
                switch (in) {
                    case "1":
                        row.put("command", "all");
                        break;

                    case "2":
                        row.put("command", "one");
                        row.put("id", 1);
                        break;

                    case "3":
                        row.put("command", "save_and_all");
                        int i = 99;
                        JSONObject obj = new JSONObject();
                        obj.put("id", i);
                        obj.put("title", i + "줴목클" + i);
                        obj.put("author", i + "누군가클" + i);
                        obj.put("content", "이거" + i + "슨 내용클");
                        row.put("obj", obj);
                        break;

                    case "4":
                        tri = false;
                    default:
                        isData = false;
                        break;
                }
                if (isData) { // 데이터 주거나 받을때
                    // 연결
                    socket = new Socket("localhost", 50001);
                    System.out.println( "[클라이언트] 연결 성공");

                    //데이터 보내기
                    String sendData = row.toString();
                    DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
                    dos.writeUTF(sendData);
                    dos.flush();
                    System.out.println("[클라이언트] 데이터 보냄: " + sendData);

                    //데이터 받기
                    DataInputStream dis = new DataInputStream(socket.getInputStream());
                    String receiveData = dis.readUTF();
                    System.out.println("[클라이언트] 데이터 받음: " + receiveData);

                    // Socket 닫기
                    socket.close();
                    System.out.println("[클라이언트] 연결 끊음");
                }
            }
		} catch(Exception e) {System.out.println("[클라이언트] 서버 연결 오류");}
	}
}


