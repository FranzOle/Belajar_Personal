package latihanprojekjavasederhana;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Enter name: ");
        String name = input.nextLine();

        System.out.println("Enter ID: ");
        int idName = input.nextInt();

        Objek obj = new Objek();
        obj.setUserName(name);
        obj.setidName(idName);

        System.out.println("Welcome! " + obj.getUserName());
    }
}

class Objek {
    private int idName;
    private String userName;

    public void setidName(int idName) {
        if (idName < 1000) {
            this.idName = idName;
        } else {
            System.out.println("Not Valid ID");
        }
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getUserName() {
        return userName;
    }

    public int getIdName() {
        return idName;
    }
}
