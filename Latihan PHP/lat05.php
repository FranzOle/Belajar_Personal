<?php 
     $tanggal = 31;

    $hasil = $tanggal < 32;

    if ($tanggal < 32) {
        if ($tanggal > 0) {
            echo 'benar';
        }
        else{
            echo 'salah';
        }
    }
    else{
        echo 'salah';
    }

    $nilai = 9;
    if ($nilai <= 100) {
        if ($nilai >= 0) {
            echo 'nilai benar';
        }
        else {
            echo 'nilai salah';
        }
    }
    
    //tes mandiri
    $nilai = 70;
    $kkm = 75;
    if ($nilai >= 0 && $nilai <= 100) {
        if ($nilai >= $kkm) {
            echo '<p style="color:blue;">LULUS</p>';
        } else {
            echo '<p style="color:red;">TIDAK LULUS</p>';
        }
    } else {
        echo '<p style="color:red;">Nilai harus antara 0 dan 100</p>';
    }
    
?>