<?php   
    $nome = $_GET['nome'];
    $senha_entrada = $_GET['senha'];

    $usuario_entrada = strtolower($nome);
    $senha_entrada = strtolower($senha_entrada);

    $usuario = strtolower("Pedro");
    $senha = strtolower("Senha");

    if ($usuario_entrada == $usuario && $senha_entrada == $senha){
        echo "Bem vindo ".$usuario;
    } else {
        echo "Dados inválidos";
    }

?>
    