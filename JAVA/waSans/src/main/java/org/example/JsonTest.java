package org.example;

import org.json.JSONArray;
import org.json.JSONObject;

public class JsonTest {

    public static int testWow = 22;
    public static void main(String[] args) {
        // [ 보내기 ]
        JSONArray jsonArr = new JSONArray();

        for (int i = 0; i < 3; i++) {
            JSONObject row = new JSONObject();
            row.put("id", i);
            row.put("content", "Hello World == "+i);
            jsonArr.put(row);
        }

        String res = jsonArr.toString();
        System.out.println(res);
        System.out.println("-----------------------------------");

        // [ 받기 ]
        JSONArray jsonRes = new JSONArray(res);
//        System.out.println(jsonRes.toString());
        for (int i = 0; i < 3; i++) {
//            System.out.println(jsonRes.get(i).toString());
            JSONObject row = new JSONObject(jsonRes.get(i).toString());
            System.out.println(row);
        }
    }
}
