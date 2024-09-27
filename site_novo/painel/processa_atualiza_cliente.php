<?php
    require('conecta.php');

    $id = $_GET['id'];
    $nome_novo = $_POST['nome_novo'];
    $email_novo = $_POST['email_novo'];
    $telefone_novo = $_POST['telefone_novo'];

    $update = "UPDATE clientes SET nome_cliente='$nome_novo', telefone='$telefone_novo', email_cliente='$email_novo' WHERE id_cliente='$id'";
    $conexao->query($update);

    header('Location: index.php');
?>