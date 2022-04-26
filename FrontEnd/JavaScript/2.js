console.log("2 ok")

//operatörler
//Matematiksel oparatörler
// + - * / %
// ++ -- ** 
// += -= *= /= %= 
// Mantıksal operatörler
// < > <= == ! != === !== && || 

function kontrol(){
     var a =10 ; 
     var b= "10";
     console.log("a=" + typeof a);
     console.log("b="+typeof b);
    if(a==b & typeof a== typeof b){
        //=== çalışma mantığı 
        console.log("a=b");
    }
    else{
        console.log("a!=b")
    } 
    console.log(a/0);

}

function faktoriyel (n) {
    var sonuc = 1;
    for(var i=1; i<=n; i++) {
    sonuc *=i;
    }
    return sonuc;

    var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    function diziDongu()
    {
        Console.log("for")
        for (var i = 0; i < array.Length; i++){
            var item = array[i];
            Console.log(item);
        }
        Console.log("forEach")
        array.forEach(item=> {
            console.log(item);
        });
        console.log("map")
        array.map(item=> {
            console.log(item)
        });
    }

    //arrow function
    var diziDongu2 = () => {
        
        array.map( item=> {
            array.map(item=> {
                console.log(item);
        });
        
    }
}