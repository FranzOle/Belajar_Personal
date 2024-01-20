<?php 
$nama = array("Gendra", "Andriko", "Sutan", "Moreno", "Dimas");
var_dump($nama);

echo '<br> <br>';

    foreach ($nama as $key) {
        echo $key. '<br>';
    }

    $person = array(
        "Gendra" => "Bali",
        "Andriko" => "Malang",
        "Sutan" => "Semarang",
        "Moreno" => "Surabaya",
        "Dimas" => "Kediri"
    );
echo '<br> <br>';
    foreach ($person as $i => $j){
        echo "Nama : " . $i . " Alamat: " . $j . '<br>';
    }
?>