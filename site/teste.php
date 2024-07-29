<?php

    $nome = strtolower("PedRo");
/* 
|| = or

if($nome == 'Pedro' ||$nome == 'PEDRO' || $nome == 'pedro'){
    echo "Bem vindo!";
}
else{
    echo "Usuário não encontrado!";
}
*/
    if($nome == 'pedro'){
        echo "Bem vindo!";
    }
    else{
        echo "Usuário não encontrado!";
    }

    echo "<hr>";

    /* for($x =1;$x<=10;$x++){
        if($x % 2 == 0){
            echo $x . "<br>";
        }
        else{
            echo "Ímpar" . "<br>";
        }
    };
    */

    $a = 1;
    while($a<=10){
        $a = $a + 1;  
        if($a % 2 == 0){
            echo $a . "<br>";
        }
        else{
            echo "Ímpar" . "<br>";
        }
        
          
    }
?>