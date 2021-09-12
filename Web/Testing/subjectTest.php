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

    $result_set = mysqli_query($connection,"SELECT * FROM student_subject WHERE st_roll_id = 'S0001'");
    
    while($result = mysqli_fetch_assoc($result_set)){
        $result_set2 = mysqli_query($connection,"SELECT * FROM subject WHERE subject_id = '{$result['subject_id']}'");
        while($result2 = mysqli_fetch_assoc($result_set2)){
            if($result2['subject_roll'] == 'BASKET1(O/L)'){
                $basket1 = $result2['subject_id'];
                break;
            }
            if($result2['subject_roll'] == 'BASKET2(O/L)'){
                $basket2 = $result2['subject_id'];
                break;
            }
            if($result2['subject_roll'] == 'BASKET3(O/L)'){
                $basket3 = $result2['subject_id'];
                break;
            }
        }
    }

    echo $basket1.'<br>';
    echo $basket2.'<br>';
    echo $basket3.'<br>';

    ?>
</body>
</html>