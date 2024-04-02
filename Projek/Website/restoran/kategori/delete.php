<?php 
if (isset($_GET['id'])) {
    # code...
        $id = $_GET['id'];

        $sql = "DELETE FROM tblkategori WHERE idkategori = $id";

        $db -> runSQL($sql);

        header("location:?f=kategori&m=select");
}

?>