<?php 
// Array dimensi
$nama = array("Gendra", "Andriko", "Sutan", 100, 20);
var_dump($nama);

// echo $nama[0];
// echo $nama[1];
// echo $nama[2];
// echo $nama[3];
// echo $nama[4];

echo '<br>';
 
for($i = 0; $i < 5; $i++){
    echo $nama[$i] . '<br>';
}

foreach ($nama as $k) {
    echo $k. '<br>';
}

// Array asosiatif
echo '<p style="color:red;">Array Asosiatif</p>';
$person = array(
    "Gendra" => "Bali",
    "Andriko" => "Malang",
    "Sutan" => "Semarang"
);
var_dump($person);
echo '<br>';

echo $person["Gendra"] . '<br>';
echo $person["Andriko"] . '<br>';
echo $person["Sutan"] . '<br>';
echo '<br>';

$person["Gendra"] = "Sidorajo";
$person["Andriko"] = "Sidorajo";
$person["Sutan"] = "Sidorajo";
foreach ($person as $key => $value){
    echo $key . " Alamat =>" . $value;
    echo '<br>';
}
?>