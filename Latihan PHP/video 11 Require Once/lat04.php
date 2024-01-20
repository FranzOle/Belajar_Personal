<?php 
    //Operator dalam PHP

    //OPERATOR ARITMATIKA
    $a = 2;
    $b = 3;
    $c = $a + $b;
    echo $c . '<br>';

    $c = $b - $a;
    echo $c. '<br>';


    $c = $a * $b;
    echo $c . '<br>';

    $c = $a / $b;
    echo floor($c) . '<br>';

    $c = $b % $a;
    echo $c . '<br>';

    // OPERATOR LOGIKA
    echo '<p style="color:red;">OPERATOR LOGIKA</p>';
    $c = $a < $b;
    echo $c . '<br>';
    
    $c = $a > $b;
    echo $c . '<br>';
    
    $c = $a == $b;
    echo $c . '<br>'; 
    
    $c = $a != $b;
    echo $c;

    //OPERATOR INCREMENT
    echo '<p style="color:red;">OPERATOR INCREMENT</p>';
    $variabel = 1;
    echo 'Sebelum menggunakan increment = '. $variabel . '<br>';
    $variabel++;
    echo 'Sesudah menggunakan increment = '. $variabel;

    //OPERATOR STRING
    echo '<p style="color:red;">OPERATOR STRING</p>';
    $kata = 'Ban';
    $kota = 'dung';

    $hasil = $kata.$kota;

    $hasil .= ' Lautan Api';
    echo $hasil;

?>