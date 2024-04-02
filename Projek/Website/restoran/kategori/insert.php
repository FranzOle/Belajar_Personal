<h1>Insert Kategori</h1>

<div>
    <form action="" method="post">
        <div class="form-group w-50">
            <label for="">Nama Kategori</label>
            <input type="text" name="kategori" required placeholder="isi kategori" class="form-control">
        </div>

        <div class="mt-3">
            <input type="submit" name="simpan" value="simpan" class="btn btn-primary">
        </div>
    </form>
</div>

<?php 
    if (isset($_POST['simpan'])) {
        $kategori = $_POST['kategori'];

        $sql = "INSERT INTO tblkategori VALUES ('','$kategori')";

        $db -> runSQL($sql);

        header("location:?f=kategori&m=select");
    }
?>