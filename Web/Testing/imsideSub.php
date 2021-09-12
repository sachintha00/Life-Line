<?php 
require_once('../php/Connection.php');
require_once('../php/logic.php');
?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php

    $result_set = getRowCount("SELECT COUNT(*) as count FROM `subject` WHERE subject_roll = 'MAIN(O/L)'");
    // $result_set = getResultSet("SELECT COUNT(*) FROM `subject`");

    // foreach($result_set as $result){
    //     $count =  $result['count'].'<br>';
    // }

    echo $result_set;

    // echo $basket1.'<br>';
    // echo $basket2.'<br>';
    // echo $basket3.'<br>';

    ?>
</body>
</html>