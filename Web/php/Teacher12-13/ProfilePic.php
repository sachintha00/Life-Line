<?php 
require_once('../Connection.php');
session_start();
?>
<?php

if(isset($_SESSION['id'])){
    $res = mysqli_query($connection,"SELECT * FROM teacher_account WHERE teach_roll_id = '{$_SESSION['id']}'");
    if($row = mysqli_fetch_assoc($res)){

        echo '<img src="data:image/jpeg;base64,'.base64_encode($row['profile_image']).'" id="photo" width="200px" height="240px" style="" />';   
    }
    else{
        echo '<img src="" alt="Profile Picture" id="photo">';
    }
}
    
                     
?>