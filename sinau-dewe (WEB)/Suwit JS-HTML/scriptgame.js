let pilihanPlayer = null;  
let pilihanKomputer = null;
let skorPlayer = 0;
let skorKomputer = 0;
let gunting = document.querySelector("#gunting");
let kertas = document.querySelector("#kertas");
let batu = document.querySelector("#batu");
gunting.addEventListener("click", getGunting);
kertas.addEventListener("click", getKertas);
batu.addEventListener("click", getBatu);

function getKomputer() {
    let handleKomputer = Math.floor(Math.random() * 3);
    switch (handleKomputer) {
        case 0:
            pilihanKomputer = "gunting";
            break;
        case 1:
            pilihanKomputer = "kertas";
            break;
        case 2:
            pilihanKomputer = "batu";
            break;
        default:
            pilihanKomputer = "Kemungkinan error developer akan memperbaiki";
    }
}

function getGunting() {
    pilihanPlayer = "gunting";
}

function getKertas() {
    pilihanPlayer = "kertas";
}

function getBatu() {
    pilihanPlayer = "batu";
}

function FungsiGame() {
    if (pilihanPlayer === null || pilihanPlayer === undefined) {
        alert("Pilihlah dahulu");
        return; 
    }

    getKomputer();
    document.querySelector("#player").innerHTML = pilihanPlayer;
    document.querySelector("#computer").innerHTML = pilihanKomputer;

    if (pilihanPlayer === pilihanKomputer) {
    
    } else if (
        (pilihanPlayer === "gunting" && pilihanKomputer === "kertas") ||
        (pilihanPlayer === "kertas" && pilihanKomputer === "batu") ||
        (pilihanPlayer === "batu" && pilihanKomputer === "gunting")
    ) {
        skorPlayer++; 
    } else {
        skorKomputer++;  
    }

    const TampilPly = document.querySelector("#skorPlayer");
    const TampilKmp = document.querySelector("#skorKomputer");
    TampilPly.innerHTML = skorPlayer;
    TampilKmp.innerHTML = skorKomputer;
    FungsiSkor();
}

function FungsiSkor() {
    let hasil = document.querySelector("#hasil");
    let status = "Hasil";
    let stStyle = "";
    if (skorPlayer + skorKomputer === 5) {
        if (skorPlayer > skorKomputer) {
            status = "Player Menang";
            stStyle = "blue";
        } else if (skorPlayer < skorKomputer) {
            status = "Komputer Menang";
            stStyle = "red";
        } else {
            status = "Seri";
        }
        kalah(status);
    }
    hasil.style.color = stStyle;
    hasil.innerHTML = status;
}

function kalah() {
    let btn = document.querySelector("#destroy");
    btn.style.display = "none";

    let pElement = document.createElement("p");
    pElement.id = "loop";
    pElement.textContent = "Main lagi";
    pElement.onclick = PlayLoop;
    
    let Ddiv = document.querySelector("#mainLagi");
    Ddiv.appendChild(pElement);
}

function PlayLoop() {
    let pElement = document.querySelector("#loop");
    pElement.remove();

    let btn = document.querySelector("#destroy");
    btn.style.display = "block";
    
    skorKomputer = 0;
    skorPlayer = 0;

    const TampilPly = document.querySelector("#skorPlayer");
    const TampilKmp = document.querySelector("#skorKomputer");
    TampilPly.innerHTML = skorPlayer;
    TampilKmp.innerHTML = skorKomputer;
    pilihanPlayer = null;
    pilihanKomputer = null;
    document.querySelector("#player").innerHTML = "Player";
    document.querySelector("#computer").innerHTML = "Komputer";

    const hasil = document.querySelector("#hasil");
    hasil.style.color = "";
    hasil.innerHTML = "Hasil";  
}

