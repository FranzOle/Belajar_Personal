<?php 

class DB{
    private $host = "127.0.0.1";
    private $user = "root";
    private $password = "";
    private $database = "dbrestoran";
    private $koneksi;

    public function __construct(){
        $this -> koneksi = $this -> koneksiDB();
    }
    public function koneksiDB(){
        $koneksi = mysqli_connect($this -> host, $this -> user, $this -> password, $this -> database);
        return $koneksi;
    }

    public function getALL($sql)
    {
        $result = mysqli_query($this -> koneksi,$sql);
        while ($row = mysqli_fetch_assoc($result)){
            $data[] = $row;
        } 
        if (!empty($data)){
            # code...
            return $data;
        }

    }

    public function getITEM($sql){
        $result = mysqli_query($this -> koneksi,$sql);
        $row = mysqli_fetch_assoc($result);

        return $row;
    }

    public function rowCOUNT($sql){
        $result = mysqli_query($this -> koneksi,$sql);
        $count = mysqli_num_rows($result);

        return $count;
    }

    public function runSQL($sql){
        $result = mysqli_query($this -> koneksi,$sql);
    }

    public function pesan($text = ""){
        echo $text;
    }
}

    $db = new DB;

    // // $db -> pesan("success");
    // $db -> runSQL("INSERT INTO tblkategori VALUES ('', 'AIS BATU')");
    // var_dump($db);
    // $row = $db -> getITEM("SELECT * FROM tblkategori WHERE idkategori = 2");
    // $count = $db -> rowCOUNT("SELECT * FROM tblkategori");

    // echo $count;
    // var_dump($row);

    // echo $row['kategori'];

    // foreach ($row as $key) {
    //     echo $key['kategori'] . '<br>';
    // }
?>