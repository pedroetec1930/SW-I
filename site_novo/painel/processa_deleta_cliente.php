<?php
    require('conecta.php');

    $id = $_GET['id'];

    $update = "DELETE FROM clientes WHERE id_cliente='$id'";
    $conexao->query($update);

    header('Location: index.php');
?>