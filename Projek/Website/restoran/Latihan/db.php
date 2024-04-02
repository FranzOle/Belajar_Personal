<?php 

class DB{
   // Properti 
   public $host = "127.0.0.1";
   private $user = "root";
   private $password = ""; 
   private $database = "dbrestoran";
   
   public function __construct(){
        echo "fungsi construct";
   }
   //method
   public function selectData(){
        echo 'select data';
   }

   public function getDatabase(){
        return $this -> database;
   }

   public function Tampil(){
        $this -> selectData();
   }

   public static function insert() {
        echo "fungsi static";
   }
}
    DB::insert();

    $db = new DB;
    //var_dump($db);
    $db->selectData();
    echo '<br>';
    echo $db->host;
    echo '<br>';
    echo $db -> getDatabase() . ' ';
    $db -> Tampil();
?>