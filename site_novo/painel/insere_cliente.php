<?php
    require('conecta.php');
    $nome_cliente = $_REQUEST['nome'];
    $email_cliente = $_REQUEST['email']
    $telefone = $_REQUEST['tel']
    
    $insere = "INSERT INTO clientes (nome_cliente,email_cliente,telefone) VALUES ('$nome_cliente','$email_cliente','$telefone')";
    $conexao->query($insere);

    header('Location: index.php');


?>