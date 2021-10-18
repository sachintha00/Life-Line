<?php
    $connection1 = mysqli_connect('localhost','root','','lifeline_test');

    if(isset($_POST["im"])){
        $filename = addslashes($_FILES['im']['name']);
        echo '<pre>';
        print_r($filename);
        echo '</pre>';
        $tmpname = addslashes(file_get_contents($_FILES['im']['tmp_name']));
        $filetype = addslashes($_FILES['im']['type']);
        $filesize = addslashes($_FILES['im']['size']);
        //$array = array('jpg','jpeg');
        //$ext = pathinfo($filename, PATHINFO_EXTENSION);
        mysqli_query($connection1,"Insert into upload(name,image) values('{$filename}','{$tmpname}')");
    }


?>