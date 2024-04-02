<?php 

    $jumlahdata = $db -> rowCOUNT("SELECT idpelanggan FROM tblpelanggan");
    $banyak = 4;

    $halaman = ceil($jumlahdata / $banyak);

    if (isset($_GET['p'])) {
        $p = $_GET['p'];
        $mulai = ($p * $banyak) - $banyak;
    }
    else {
        $mulai = 0;
    }

    $sql = "SELECT * FROM tblpelanggan ORDER BY pelanggan ASC LIMIT $mulai,$banyak";
    $row = $db -> getALL($sql);

    $no = 1 + $mulai;
?>
<!-- <div class="float-start me-4">
    <a class="btn btn-primary" href="?f=pelangga&m=insert" role="button">Tambah Data</a>
</div> -->

<h2>Data Pelanggan</h2>
<p>Page ke-<span><?php if (isset($_GET['p'])) {
        echo $_GET['p'];}else { echo 1; } ?></span></p>
<table class="table table-bordered w-70">
    <thead>
        <th>Nomor</th>
        <th>Pelanggan</th> 
        <th>Alamat</th> 
        <th>Telepon</th> 
        <th>Email</th>
        <th>Delete</th>
        <th>Status</th>
    </thead>

    <tbody>
        <?php 
        $no = 1; 
        foreach ($row as $r): ?>
            <tr>
                <?php 
                    if ($r['aktif'] == 1) {
                        $status = 'Aktif';
                    }
                    else {
                        $status = 'Tidak Aktif';
                    }
                ?>
                <td><?php echo $no++ ?></td>
                <td><?php echo $r['pelanggan'] ?></td>
                <td><?php echo $r['alamat'] ?></td>
                <td><?php echo $r['telepon'] ?></td>
                <td><?php echo $r['email'] ?></td>
                <td><a href="?f=pelanggan&m=delete&id=<?php echo $r['idpelanggan'] ?>">Delete Data</a></td>
                <td><a href="?f=pelanggan&m=update&id=<?php echo $r['idpelanggan'] ?>"><?php echo $status ?></a></td>
            </tr>
        <?php endforeach ?>
    </tbody>
</table>

<?php 
    for($i = 1; $i <= $halaman ; $i++){
        echo '<a href="?f=pelanggan&m=select&p=' . $i . '">' . $i . '</a>';
        echo '&nbsp &nbsp &nbsp';
    }
?>