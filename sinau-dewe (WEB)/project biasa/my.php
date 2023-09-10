<!DOCTYPE html>
<html>
<head>
    <title>Proses Data Form</title>
</head>
<body>
    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $nama = $_POST["nama"];
        $email = $_POST["email"];
        
        echo "<h2>Hasil Pengiriman Form</h2>";
        echo "Nama: " . $nama . "<br>";
        echo "Email: " . $email . "<br>";
    }
    ?>
</body>
</html>
