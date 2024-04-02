<?php 
if (isset($_GET['id'])) {
    # code...
        $id = $_GET['id'];

        $sql = "DELETE FROM tblpelanggan WHERE idpelanggan = $id";

        $db -> runSQL($sql);

        header("location:?f=pelanggan&m=select");
}

?>