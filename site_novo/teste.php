<?php
$nome = strtolower('Anderson');

if ($nome = 'anderson') {
    echo "<span style='color: red;'>$nome</span><br>";
} else {
    echo "$nome";
}

for ($i = 0; $i <= 10; $i++) {
    if ($i / 2 % 2 == 0) {
        echo "$i<br>";
    }
}

$a = 0;
while ($a <= 10) {
    echo $a;
    $a++;
}