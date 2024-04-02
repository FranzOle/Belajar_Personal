<h1>Chechkout Menu</h1>

<?php
if (isset($_GET['total'])) {
    $total = $_GET['total'];

    $idorder = idorder();
    $idpelanggan = $_SESSION['idpelanggan'];
    $tgl = date('Y-m-d');

    $sql = "SELECT * FROM tblorder WHERE idorder = $idorder";

    $count = $db->rowCOUNT($sql);

    if ($count == 0) {
        insertOrder($idorder, $idpelanggan, $tgl, $total);
        insertOrderDetail($idorder);
    } else {
        insertOrderDetail($idorder);
    }
    kosongkanSession();
    header("location:?f=home&m=checkout");
} else {
    info();
}


function idorder() {
    global $db;
    $sql = "SELECT idorder FROM tblorder ORDER BY idorder DESC";
    $jumlah = $db -> rowCOUNT($sql);

    if ($jumlah == 0) {
        $id = 1;
    } else {
        $item = $db -> getITEM($sql);
        $id = $item['idorder'] + 1;
    }

    return $id;
}

function insertOrder($idorder, $idpelanggan, $tgl, $total) {
    global $db;
    $sql = "INSERT INTO tblorder VALUES ($idorder, $idpelanggan,'$tgl', $total, 0, 0, 0)";

    echo $sql;
    $db -> runSQL($sql);
}


function insertOrderDetail($idorder = 1) {
    global $db;

    foreach ($_SESSION as $key => $value) {
        if ($key <> 'pelanggan' && $key <> 'idpelanggan' && $key <> 'user' && $key <> 'level' && $key <> 'iduser') {
            $id = substr($key, 1);

            $sql = "SELECT * FROM tblmenu WHERE idmenu=$id";

            $row = $db->getALL($sql);

            foreach ($row as $r) {
                $idmenu = $r['idmenu'];
                $harga = $r['harga'];
                $sql = "INSERT INTO tblorderdetail VALUES ('',$idorder, $idmenu, $value, $harga)";
                $db -> runSQL($sql);
            }
           /* echo '<pre>';
            print_r($row);
            echo '</pre>'; */
        }
    }
}


function kosongkanSession() {
    foreach ($_SESSION as $key => $value) {
        if ($key <> 'pelanggan' && $key <> 'idpelanggan') {
            $id = substr($key, 1);
            unset($_SESSION['_' . $id]);
        }
    }
}

function info() {
    echo "<h3>Terima Kasih Sudah Berbelanja !</h3>";
}