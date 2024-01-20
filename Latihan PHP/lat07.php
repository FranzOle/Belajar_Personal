<?php 
//LOOP PHP

//loop for
echo '<h1>Loop for</h1>';
echo '<br>';
for ($i = 1; $i <= 12 ; $i++) { 
    echo $i . ',';
}
echo '<br>';

echo '<p style="color:blue;">tambah 2 per angka</p>';
for ($i = 2; $i <= 12 ; $i = $i + 2) { 
    echo $i . ',';
}

echo '<p style="color:blue;">loop dari belakang menggunakan decrement</p>';
for ($i = 12; $i >= 1 ; $i--) { 
    echo $i . ',';
}
echo '<br>';
echo 'segitiga loop : ' . '<br>';
for($i = 1; $i <= 5; $i++){
    for($j = 1; $j < $i; $j++){
        echo '* ';
    } echo '<br>';
}

echo '<h1>Loop while</h1>';

echo '<h1>While-do</h1>';
$a = 1;
while ($a <= 10) {
    echo $a. ',';
    $a++;
}
echo '<br>';

echo '<h1>do-While</h1>';
$b = 1;
do{
    echo $a.',';
    $a++;
}while ($a <= 10);
?>