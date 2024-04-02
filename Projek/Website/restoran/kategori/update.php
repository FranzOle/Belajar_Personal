<h3>Update Data Kategori</h3>

<?php
    if (isset($_GET['id'])) {
        # code...
        $id = $_GET['id'];
        
        $sql = "SELECT * FROM tblkategori WHERE idkategori = $id";

        $row = $db -> getITEM($sql);
    }
?>

<div>
    <form action="" method="post">
        <div class="form-group w-50">
            <label for="">Nama Kategori</label>
            <input type="text" name="kategori" required placeholder="isi kategori" class="form-control" value="<?php echo $row['kategori']; ?>">
        </div>

        <div class="mt-2">
            <input type="submit" name="simpan" value="simpan" class="btn btn-primary">
        </div>
        </div>
    </form>
</div>

<?php 
    if (isset($_POST['simpan'])) {
        $kategori = $_POST['kategori'];

        $sql =  "UPDATE tblkategori SET kategori = '$kategori' WHERE idkategori = $id";
    
        $db -> runSQL($sql);

        header("location:?f=kategori&m=select");
    }
?>