<?php 
    //SWITCH CASE 
    $hari = 4;
    switch ($hari) {
        case 1:
            echo "Senin";
            break;
        case 2:
            echo "Selasa";
            break;
        case 3:
            echo "Rabu";
            break;
        case 4:
            echo "Kamis";
            break;
        case 5:
            echo "Jumat";
            break;
        case 6:
            echo "Sabtu";
            break;
        case 7:
            echo "Minggu";
            break;
        default:
            echo 'Hari belum dibuat';
            break;
    }
    echo "<br>";

    $pilihan = "tambah";
    switch ($pilihan) {
        case "ubah":
            echo "anda memilih ubah";
            break;

        case "tambah":
            echo "anda memilih tambah";
            break;

        case "hapus":
            echo "anda memilih hapus";
            break;

        default:
            echo "pilihan belum dibuat";
            break;
    }
?>