
  document.querySelector("#val-c").addEventListener("input", function() {
  document.querySelector("#val-f").disabled = this.value !== "";
  document.querySelector("#val-r").disabled = this.value !== "";
});

  document.querySelector("#val-f").addEventListener("input", function() {
  document.querySelector("#val-c").disabled = this.value !== "";
  document.querySelector("#val-r").disabled = this.value !== "";
});

  document.querySelector("#val-r").addEventListener("input", function() {
  document.querySelector("#val-c").disabled = this.value !== "";
  document.querySelector("#val-f").disabled = this.value !== "";
});

merah.onclick = () => {
    let celsius = parseFloat(document.querySelector("#val-c").value);
if(isNaN(celsius)){
    alert("NILAI KOSONG WOI");
}
else{
    let pil = document.querySelectorAll("span");
    for(let i=0; i<pil.length; i++){
                    switch(i){
                        case 0:
                            pil[i].innerHTML = celsius;
                            break;
                        case 1:
                            pil[i].innerHTML =(celsius * 9/5) + 32;
                            break;
                        case 2:
                            pil[i].innerHTML = celsius * 4/5;
                            break;
                    }
                }}
        
    };
    
    biru.onclick = () => {
    let fahrenheit = parseFloat(document.querySelector("#val-f").value);

    if (isNaN(fahrenheit)) {
        alert("NILAI KOSONG WOI");
    } else {
        let pil = document.querySelectorAll("span");
        for (let i = 0; i < pil.length; i++) {
            switch (i) {
                case 0:
                    pil[i].innerHTML = ((fahrenheit - 32) * 5 / 9).toFixed(2);
                    break;
                case 1:
                    pil[i].innerHTML = fahrenheit.toFixed(2);
                    break;
                case 2:
                    pil[i].innerHTML = ((fahrenheit - 32) * 4 / 9).toFixed(2);
                    break;
            }
        }
    }
};

hijau.onclick = () => {
    let reamur = parseFloat(document.querySelector("#val-r").value);

    if (isNaN(reamur)) {
        alert("NILAI KOSONG WOI");
    } else {
        let pil = document.querySelectorAll("span");
        for (let i = 0; i < pil.length; i++) {
            switch (i) {
                case 0:
                    pil[i].innerHTML = (reamur * 5 / 4).toFixed(2);
                    break;
                case 1:
                    pil[i].innerHTML = (reamur * 9 / 4 + 32).toFixed(2);
                    break;
                case 2:
                    pil[i].innerHTML = reamur.toFixed(2);
                    break;
            }
        }
    }
};