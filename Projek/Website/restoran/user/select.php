<h1>User</h1>
<?php 

    $jumlahdata = $db -> rowCOUNT("SELECT iduser FROM tbluser");
    $banyak = 4;

    $halaman = ceil($jumlahdata / $banyak);

    if (isset($_GET['p'])) {
        $p = $_GET['p'];
        $mulai = ($p * $banyak) - $banyak;
    }
    else {
        $mulai = 0;
    }

    $sql = "SELECT * FROM tbluser ORDER BY user ASC LIMIT $mulai,$banyak";
    $row = $db -> getALL($sql);

    $no = 1 + $mulai;
?>
<div class="float-start me-4">
    <a class="btn btn-primary" href="?f=user&m=insert" role="button">Tambah Data</a>
</div>

<p>Page ke-<span><?php if (isset($_GET['p'])) {
        echo $_GET['p'];}else { echo 1; } ?></span></p>
<table class="table table-bordered w-50 mt-4">
    <thead>
        <th>Nomor</th>
        <th>User</th>
        <th>Email</th>
        <th>Level</th>
        <th>Delete</th>
        <th>Status</th>
    </thead>

    <tbody>
        <?php 
        $no = 1; 
        foreach ($row as $r): ?>
        <?php 
                if ($r['aktif'] == 1) {
                    $status = "Aktif";
                }
                else {
                    $status ="Banned";
                }
            ?>
            <tr>
                <td><?php echo $no++ ?></td>
                <td><?php echo $r['user'] ?></td>
                <td><?php echo $r['email'] ?></td>
                <td><?php echo $r['level'] ?></td>
                <td><a href="?f=user&m=delete&id=<?php echo $r['iduser'] ?>">Delete</a></td>
                <td><a href="?f=user&m=update&id=<?php echo $r['iduser'] ?>"><?php echo $status; ?></a></td>
            </tr>
        <?php endforeach ?>
    </tbody>
</table>

<?php 
    for($i = 1; $i <= $halaman ; $i++){
        echo '<a href="?f=user&m=select&p=' . $i . '">' . $i . '</a>';
        echo '&nbsp &nbsp &nbsp';
    }
?>