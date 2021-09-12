<?php 
require_once('../Connection.php');
session_start();
?>
<?php

if(isset($_SESSION['id'])){
    $res = mysqli_query($connection,"SELECT * FROM teacher_account WHERE teach_roll_id = '{$_SESSION['id']}'");
    if($row = mysqli_fetch_assoc($res)){
        ?>

        <form action="" method="post">
                <div class="input-box">
                    <input type="text" required="" name="username" value="<?php echo $row['username'] ?>">
                    <span class="floatingLabel">Username</span>
                </div>
                <div class="input-box">
                    <input type="password" required="" name="password" value="<?php echo $row['password'] ?>">
                    <span class="floatingLabel">Password</span>
                </div>
        </form>

<?php
    }
}
?>