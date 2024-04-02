<h3>Daftar Pelanggan</h3>

<div>
    <form action="" method="post">
        <div class="form-group w-50">
            <label for="">Pelanggan</label>
            <input type="text" name="pelanggan" required placeholder="isi pelanggan" class="form-control">
        </div>

        <div class="form-group w-50">
            <label for="">Alamat</label>
            <input type="text" name="alamat" required placeholder="isi alamat" class="form-control">
        </div>

        <div class="form-group w-50">
            <label for="">No Telepon</label>
            <input type="text" name="telp" required placeholder="isi telp" class="form-control">
        </div>

        <div class="form-group w-50">
            <label for="">Email</label>
            <input type="email" name="email" required placeholder="Email" class="form-control">
        </div>

        <div class="form-group w-50">
            <label for="">Password</label>
            <input type="password" name="password" required placeholder="password" class="form-control">
        </div>

        <div class="form-group w-50">
            <label for="">Konfirmasi Password</label>
            <input type="password" name="konfirmasi" required placeholder="password" class="form-control">
        </div>
        <div>
            <input type="submit" name="simpan" value="simpan" class="btn btn-primary mt-2">
        </div>
    </form>
</div>

<?php
if (isset($_POST['simpan'])) {
    $pelanggan = $_POST['pelanggan'];
    $alamat = $_POST['alamat'];
    $telp = $_POST['telp'];

    $email = $_POST['email'];
    $password = $_POST['password'];
    $konfirmasi = $_POST['konfirmasi'];

    if ($password === $konfirmasi) {
        $sql = "INSERT INTO tblpelanggan VALUES ('','$pelanggan','$alamat','$telp','$email','$password',1)";
        echo $sql;
        $db->runSQL($sql);
        header("location:?f=home&m=info");
    } else {
       echo "<center><h3>Email atau Password salah</h3></center>";
    }
}
?>