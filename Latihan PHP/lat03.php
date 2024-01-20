<?php 
    function Belajar(){
        echo "Saya belajar php smk Revit";
    }

    Belajar();
    
    function luasPersegi($p = 5, $l = 3){
        $luas = $p * $l;
        echo $luas;
    }

    luasPersegi(10, 3);

    function output(){
        return "Saya Belajar PhP";
    }
    echo '<h1>'.output().'</h1>';

    function LuasBalok($panjang, $lebar, $tinggi){
        return $panjang * $lebar * $tinggi;
    }
    $luasSegitiga = LuasBalok(12,5,10);
    echo 'Luas Segitiga adalah '. $luasSegitiga;
?>