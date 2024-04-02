<!-- Tes Detail -->

<?php
    if (isset($_GET['id'])) {
        $id = $_GET['id'];
    }

    $jumlahdata = $db -> rowCOUNT("SELECT idorderdetail FROM vorderdetail WHERE idorder = '$id'");
    $banyak = 3;

    $halaman = ceil($jumlahdata / $banyak);

    if (isset($_GET['p'])) {
        $p = $_GET['p'];
        $mulai = ($p * $banyak) - $banyak;
    } else {
        $mulai = 0;
    }

    $sql = "SELECT * FROM vorderdetail WHERE idorder = '$id' ORDER BY idorderdetail ASC LIMIT $mulai,$banyak";
    $row = $db -> getALL($sql);

    $no = 1 + $mulai;
?>
<!-- <div class="float-start me-4">
    <a class="btn btn-primary" href="?f=kategori&m=insert" role="button">Tambah Data</a>
</div> -->

<h2>Detail Pembelian</h2>
<p>Page ke-<span><?php if (isset($_GET['p'])) {
        echo $_GET['p'];}else { echo 1; } ?></span></p>

<table class="table table-bordered w-70">
    <thead>
        <th>Nomor</th>
        <th>Tanggal</th>
        <th>Menu</th>
        <th>Harga</th>
        <th>Jumlah</th>
    </thead>

    <tbody>
    <?php if(!empty($row)){ ?>
        <?php 
        $no = 1; 
        foreach ($row as $r): ?>
            <tr>
                <td><?php echo $no++ ?></td>
                <td><?php echo $r['tglorder'] ?></td>
                <td><?php echo $r['menu'] ?></td>
                <td><?php echo $r['harga'] ?></td>
                <td><?php echo $r['jumlah'] ?></td>
           </tr>
        <?php endforeach ?>
        <?php } ?>
    </tbody>
</table>

<?php 
    for ($i = 1; $i <= $halaman; $i++) {
        echo '<a href="?f=home&m=detail&id=' . $r['idorder'] . '&p=' . $i . '">' . $i . '</a>';
        echo '&nbsp &nbsp &nbsp';
    }
?> 