<?php 
require_once('../Connection.php');
session_start();
?>
<?php

if(isset($_SESSION['id'])){
    $res = mysqli_query($connection,"SELECT * FROM teacher_account WHERE teach_roll_id = '{$_SESSION['id']}'");
    if($row = mysqli_fetch_assoc($res)){
        ?>

<form action="login.php" method="post">
    <div class="input-box">
        <input type="text" required="" name="gmail" value="<?php echo $row['gmail'] ?>">
        <span class="floatingLabel">Gmail</span>
    </div>
    <div class="input-box">
        <input type="text" required="" name="mobile" value="<?php echo $row['teach_tp_number'] ?>">
        <span class="floatingLabel">Mobile Number</span>
    </div>
</form>

<?php
    }
}
?>