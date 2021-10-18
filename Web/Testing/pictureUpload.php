<?php
    $connection1 = mysqli_connect('localhost','root','','lifeline_test');

    if(isset($_POST["submit"])){
        $filename = addslashes($_FILES['img']['name']);
        $tmpname = addslashes(file_get_contents($_FILES['img']['tmp_name']));
        $filetype = addslashes($_FILES['img']['type']);
        $filesize = addslashes($_FILES['img']['size']);
        //$array = array('jpg','jpeg');
        //$ext = pathinfo($filename, PATHINFO_EXTENSION);
        mysqli_query($connection1,"Insert into upload(name,image) values('{$filename}','{$tmpname}')");


        //display
        $res = mysqli_query($connection1,"SELECT * FROM upload WHERE id = '363'");
        $row = mysqli_fetch_assoc($res);
        echo '<img src="data:image/jpeg;base64,'.base64_encode($row['image']).'" />';
        // echo '<img src="data:image/jpeg;base64,&#39;.base64_encode($displ).&#39;" />';
        // echo "<br />";
    }


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
    <form action="pictureUpload.php" method="post" enctype="multipart/form-data">
        <input type="file" name="img" id="d">
        <label for="d">upload chose</label>
        <button name="submit" id="bu">Upload</button>
    </form>

    <form action="pictureUpload.php">
        <label for="bu">Button</label>
    </form>
    <script>
    </script>
</body>
</html>