<?php 
require_once('../Connection.php');
session_start();
?>
<?php

if(isset($_SESSION['id'])){
    $res = mysqli_query($connection,"SELECT * FROM student_account WHERE st_roll_id = '{$_SESSION['id']}'");
    if($row = mysqli_fetch_assoc($res)){
        ?>

        <form action="" method="post">
                <div class="input-group d-flex">
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['st_first_name'] ?>">
						<span class="floatingLabel">First Name</span>
					</div>
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['st_middle_name'] ?>">
						<span class="floatingLabel">Middle Name</span>
					</div>
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['st_surname'] ?>">
						<span class="floatingLabel">Surname</span>
					</div>
				</div>
                <div class="input-group d-flex">
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['st_nic'] ?>">
						<span class="floatingLabel">National Id Number</span>
					</div>
					<div class="input-box">
						<span class="">Lorem ipsum dolor sit amet consectetur<br> adipisicing elit. Repellendus, voluptatibus!</span>
					</div>
				</div>
                <div class="input-group d-flex">
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['address'] ?>">
						<span class="floatingLabel">Address</span>
					</div>
					<div class="input-box">
						<input type="text" required="" value="<?php echo $row['city'] ?>">
						<span class="floatingLabel">city</span>
					</div>
				</div>
                
        </form>

<?php
    }
}
?>