
function DewaKamu(){ 
    const tanggal = document.getElementById("tgl").value;
    let Objek = new Date(tanggal);
    const nama = document.getElementById("name").value;
    var bulan = Objek.getMonth()+1;
    var hari = Objek.getDate();

    var dewa = "";
    if(nama.trim()==""){
        alert("Isi data diri terlebih dulu :)");
    }
    else{
    if(bulan==1){
        if (hari>0 && hari<25) {
            dewa="Osiris";
        }
        else if (hari>=25 && hari<32) {
            dewa="Thor";
        }
    }
    if(bulan==2){
        if (hari>0 && hari <17) {
            dewa="Loki";
        }
        else if (hari >=17 && hari<29) {
            dewa ="athena";
        } else if (hari==29) {
            dewa="Kratos";
        }
    }
    if(bulan==3){
        if (hari> 0 && hari <20) {
            dewa ="Tlaloc";
        }
        else if (hari>=20) {
            dewa ="Horus";
        } 
    }
    if(bulan==4){
        if (hari> 0 && hari <15) {
            dewa="Hades";
        }
        else if (hari>=15) {
            dewa="Ra";
        }
    }
    if(bulan==5){
        if (hari> 0 && hari <16) {
            dewa ="Zeus";
        }
        else if (hari>=16) {
            dewa="Odin";
        }
    }
    if(bulan==6){
        if (hari> 0 && hari <20) {
            dewa="Siwa";
        }
        else if (hari>=20) {
           dewa ="Freyr"; 
        } 
    }
    if(bulan==7){
        if (hari> 0 && hari <10) {
           dewa ="Tyr"; 
        }
        else if (hari>=10) {
           dewa ="Hera"; 
        } 
    }
    if(bulan==8){
        if (hari> 0 && hari <30) {
           dewa ="Poseidon"; 
        }
        else if (hari>=30) {
            dewa ="Odin";
        } 
    }
    if(bulan==9){
        if (hari> 0 && hari <23) {
           dewa ="Odin"; 
        }
        else if (hari>=23) {
          dewa ="ares";  
        }
    }
    if(bulan==10){
        if (hari> 0 && hari <19) {
           dewa ="Baldur"; 
        }
        else if (hari>=19) {
            dewa ="Collosus";
        } 
    }
    if(bulan==11){
        if (hari> 0 && hari <16) {
            dewa ="Minerva";
        }
        else if (hari>=16) {
           dewa ="Jupiter"; 
        } 
    }
    if(bulan==12){
        if (hari >0 && hari<25) {
            dewa ="Neptunus";
        }
        else if (hari>=25) {
            dewa ="Mars";
        }         
    } 
    document.querySelector("#hasil").innerHTML= nama + ", Dewa kamu adalah "+dewa;
    document.querySelector("#result").innerHTML = "Mari temukan pengalaman seru di society.fun"
        }
    }
