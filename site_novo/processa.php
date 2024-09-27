<?php
$nome = $_POST['nome'];
$idade = $_POST['idade'];
$email = $_POST['email'];

if ($nome == 'ANDERSON') {
    echo "<span style='color: red;'>$nome</span><br>";
} else {
    echo "$nome";
}
echo "$idade<br>";
echo "$email<br>";