  document.addEventListener("DOMContentLoaded", function () {
    let c_f = document.getElementById("merah");
    let c_r = document.getElementById("biru");
    let f_c = document.getElementById("hijau");
    let f_r = document.getElementById("kuning");
    let r_c = document.getElementById("ungu");
    let r_f = document.getElementById("oranye");

    let hasilObj = document.querySelector("#hasil");

    c_f.addEventListener("click", CelToFahr);
    c_r.addEventListener("click", CelToRmr);
    f_c.addEventListener("click", FahrToCel);
    f_r.addEventListener("click", FahrToRmr);
    r_c.addEventListener("click", RmrToCel);
    r_f.addEventListener("click", RmrToFahr);

    function CelToFahr() {
        let celsius = parseFloat(document.getElementById("val-c").value);

        if (!isNaN(celsius)) {
            const convert = (celsius * 9/5) + 32;
            hasilObj.innerHTML = "Hasil konversi ke Fahrenheit: " + convert.toFixed(2) + " °F";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Celsius.";
        }
    }

    function CelToRmr() {
        let celsius = parseFloat(document.getElementById("val-c").value);

        if (!isNaN(celsius)) {
            const convert = (4/5) * celsius;
            hasilObj.innerHTML = "Hasil konversi ke Reamur adalah " + convert.toFixed(2) + " R";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Celsius.";
        }
    }

    function FahrToCel() {
        let fahrenheit = parseFloat(document.getElementById("val-f").value);

        if (!isNaN(fahrenheit)) {
            const convert = (fahrenheit - 32) * 5/9;
            hasilObj.innerHTML = "Hasil konversi ke Celsius: " + convert.toFixed(2) + " °C";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Fahrenheit.";
        }
    }

    function FahrToRmr() {
        let fahrenheit = parseFloat(document.getElementById("val-f").value);

        if (!isNaN(fahrenheit)) {
            const convert = (5/9) * (fahrenheit - 32) * 4/5;
            hasilObj.innerHTML = "Hasil konversi ke Reamur adalah " + convert.toFixed(2) + " R";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Fahrenheit.";
        }
    }

    function RmrToCel() {
        let reamur = parseFloat(document.getElementById("val-r").value);

        if (!isNaN(reamur)) {
            const convert = (5/4) * reamur;
            hasilObj.innerHTML = "Hasil konversi ke Celsius: " + convert.toFixed(2) + " °C";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Reamur.";
        }
    }

    function RmrToFahr() {
        let reamur = parseFloat(document.getElementById("val-r").value);

        if (!isNaN(reamur)) {
            const convert = ((5/4) * reamur * 9/5) + 32;
            hasilObj.innerHTML = "Hasil konversi ke Fahrenheit: " + convert.toFixed(2) + " °F";
        } else {
            hasilObj.innerHTML = "Masukkan angka yang valid untuk Reamur.";
        }
    }
});
