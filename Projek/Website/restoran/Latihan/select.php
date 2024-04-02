<div style="margin:auto; width:900px;">
<h1><a href="http://localhost/PHP-Video-SMKREVIT/restoran/kategori/insert.php">Tambah Data</a></h1>

<?php 

    require_once "../function.php";

    if (isset($_GET['update'])) {
        $id = $_GET['update'];
        require_once "update.php";
    }

    if (isset($_GET['hapus'])) {
        $id = $_GET['hapus'];
        require_once "delete.php";
    }

    $sql = "SELECT idkategori FROM tblkategori";
    $result = mysqli_query($koneksi, $sql); 

    $jumlahdata = mysqli_num_rows($result);
    
    echo "Jumlah data " . $jumlahdata;
    echo '<br>';
    //LIMIT $mulai dari data mana dan $banyak sampai mana 
    $mulai = 3;
    $banyak = 3;
    
    $halaman = ceil($jumlahdata / $banyak);

    for ($i = 1; $i <= $halaman; $i++) { 
        # code...
        echo '<a href="?p='.$i.'">' . $i . '</a>';
        echo '&nbsp &nbsp &nbsp';
    }

    if (isset($_GET['p'])) {
        $p=$_GET['p'];
       $mulai = ($p * $banyak) -$banyak;      
    }
    else {
        $mulai = 0;
    }
    // echo "Jumlah Halaman : " . ceil($halaman);
    

    $sql = "SELECT * FROM tblkategori LIMIT $mulai, $banyak"; 
    $result = mysqli_query($koneksi, $sql);
    
    $jumlah = mysqli_num_rows($result);
    echo '<br>';
    // echo $jumlah;
    echo'<br><br>';

    echo '
    <table border="1px">
    <tr>
        <th>No</th>
        <th colspan=3 >Kategori</th>
    </tr>
    ';
    $no = $mulai + 1;
    if ($jumlah) {
        while ($row = mysqli_fetch_assoc($result)) {
            echo '<tr>';
            echo '<td>' . $no++ . '</td>';
            echo '<td>' . $row['kategori'] . '</td>';
            echo '<td><a href="?hapus='.$row['idkategori'] . '">' . 'Hapus' . '</a></td>';
            echo '<td><a href="?update='.$row['idkategori'].'">' . 'Update' . '</a></td>';
            echo '</tr>';
        }
    }
    echo '</table>';
?>

</div>
    
