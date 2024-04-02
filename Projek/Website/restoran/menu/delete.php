<?php 
if (isset($_GET['id'])) {
    # code...
        $id = $_GET['id'];

        $sql = "DELETE FROM tblmenu WHERE idmenu = $id";

        $db -> runSQL($sql);

        header("location:?f=menu&m=select");
}

?>