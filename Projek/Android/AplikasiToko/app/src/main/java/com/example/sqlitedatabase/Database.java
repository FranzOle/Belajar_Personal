package com.example.sqlitedatabase;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class Database extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "dbtoko";
    private static final int VERSION = 1;

    SQLiteDatabase db;

    public Database(Context context) {
        super(context, DATABASE_NAME, null, VERSION);
        db = this.getWritableDatabase();
    }
    boolean runSQL(String sql){
        try{
            db.execSQL(sql);
            return true;

        } catch (Exception e){
            return  false;
        }
    }
    Cursor select(String sql){
        try{
            return  db.rawQuery(sql,null);
        }catch (Exception e){
            return  null;
        }
    }

    public void buatTabel(){
        String tblbarang = "CREATE TABLE \"tblbarang\" (\n" +
                "\t\"idbarang\"\tINTEGER,\n" +
                "\t\"barang\"\tTEXT,\n" +
                "\t\"stok\"\tREAL,\n" +
                "\t\"harga\"\tREAL,\n" +
                "\tPRIMARY KEY(\"idbarang\" AUTOINCREMENT)\n" +
                ");";
        runSQL(tblbarang);
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {

    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }
}