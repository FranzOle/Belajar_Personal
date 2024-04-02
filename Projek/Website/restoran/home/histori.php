<!-- <p>Tes</p> -->

<?php 
    $email = $_SESSION['pelanggan'];
    $jumlahdata = $db -> rowCOUNT("SELECT idorder FROM vorder WHERE email = '$email'");
    $banyak = 3;

    $halaman = ceil($jumlahdata / $banyak);

    if (isset($_GET['p'])) {
        $p = $_GET['p'];
        $mulai = ($p * $banyak) - $banyak;
    }
    else {
        $mulai = 0;
    }

    $sql = "SELECT * FROM vorder WHERE email = '$email' ORDER BY tglorder DESC LIMIT $mulai, $banyak";
    $row = $db -> getALL($sql);

    $no = 1 + $mulai;
?>

<h2>Histori Pembelian</h2>
<p>Page ke-<span><?php if (isset($_GET['p'])) {
        echo $_GET['p'];}else { echo 1; } ?></span></p>
<table class="table table-bordered w-50">
    <thead>
        <th>Nomor</th>
        <th>Tanggal</th>
        <th>Total</th>
        <th>Detail</th>
    </thead>

    <tbody>
    <?php if(!empty($row)){ ?>
        <?php 
        $no = 1; 
        foreach ($row as $r): ?>
            <tr>
                <td><?php echo $no++ ?></td>
                <td><?php echo $r['tglorder'] ?></td>
                <td>Rp. <?php echo $r['total'] ?></td>
                <td><a href="?f=home&m=detail&id=<?php echo $r['idorder'] ?>">Detail Order</a></td     
           </tr>
        <?php endforeach ?>
        <?php } ?>
    </tbody>
</table>

<?php 
    for($i = 1; $i <= $halaman ; $i++){
        echo '<a href="?f=home&m=histori&p=' . $i . '">' . $i . '</a>';
        echo '&nbsp &nbsp &nbsp';
    }
?>
