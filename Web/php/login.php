<?php session_start(); ?>

<?php 

require_once('Connection.php'); 
include('logic.php');

?>

<?php

    $errors = array() ;
    if(isset($_POST['submit'])){
        if(!isset($_POST['username']) || strlen(trim($_POST['username']))<1){
            $errors[] =  'Invalid';
        }
        else if(!isset($_POST['password']) || strlen($_POST['username'])<1){
            $errors[] =  'Invalid';
        }
        else{

            if(mysqli_num_rows(tabaleSelector('other_staff_account'))==1){
                $record =  getValue("SELECT * FROM other_staff_account WHERE username = '{$_POST['username']}' AND password = '{$_POST['password']}'");
                if($record['staff_roll_name'] == 'Academic'){
                    $_SESSION['id'] = $record['staff_roll_id'];
                    $_SESSION['rollName'] = $record['staff_roll_name'];
                    header("Location:../php/AcademicStaff/AcademicMain.php");
                }
            }
            else if(mysqli_num_rows(tabaleSelector('student_account'))==1){
                $record = getValue("SELECT * FROM student_account WHERE username = '{$_POST['username']}' AND password = '{$_POST['password']}'");
                if($record['st_roll_name'] == 'GRADE6-11'){
                    $_SESSION['id'] = $record['st_roll_id'];
                    $_SESSION['rollName'] = $record['st_roll_name'];
                    header("Location:../php/Student/StudentMain.php");
                }
                if($record['st_roll_name'] == 'GRADE12-13'){
                    $_SESSION['id'] = $record['st_roll_id'];
                    $_SESSION['rollName'] = $record['st_roll_name'];
                    header("Location:../php/Student/StudentMain.php");
                }
            }
            else if(mysqli_num_rows(tabaleSelector('teacher_account'))==1){
                $record =  getValue("SELECT * FROM teacher_account WHERE username = '{$_POST['username']}' AND password = '{$_POST['password']}'");         
                if($record['teach_roll_name'] == 'Teacher6-11'){
                    $_SESSION['id'] = $record['teach_roll_id'];
                    $_SESSION['rollName'] = $record['teach_roll_name'];
                    header("Location:../php/Teacher/TeacherMain.php");
                }
                if($record['teach_roll_name'] == 'Teacher12-13'){
                    $_SESSION['id'] = $record['teach_roll_id'];
                    $_SESSION['rollName'] = $record['teach_roll_name'];
                    header("Location:../php/Teacher12-13/TeacherMain.php");
                }
            }
            else{
                $errors = 'invalid username password';
            }
        }
    }

?>


<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Life Line</title>
	<link rel="stylesheet" href="../css/SignUpForm.css">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
</head>
<body>
	<div class="container" id="particles-js">
		<img src="../resource/login.svg" alt="" class="img img-1">
		<img src="../resource/login.svg" alt="" class="img img-2">
		
        <div class="Login-SignUp-box login" id="loginSignUp">

            <div class="inner-box" id="signin">
                <div style="width: 100%;">
                    <p>LIFE LINE <br>LOGIN</p>

                <form action="login.php" method="post">
                    <!-- <h3 class="error"></h3>              -->
                    <div class="input-box">
                        <input type="text" required="" name="username">
                        <span class="floatingLabel">Username</span>
                    </div>
                    <div class="input-box">
                        <input type="text" required="" name="password">
                        <span class="floatingLabel">Password</span>
                    </div>
                    <div class="button-box signin-button-box">
                        <button name="submit">SIGN IN</button>
                    </div>
                </form>

                </div>
            </div>

		</div>
	</div>
	
	<script src="js/particles.min.js"></script>
	<script src="js/app.js"></script>
	<script src="js/main.js"></script>
</body>
</html>