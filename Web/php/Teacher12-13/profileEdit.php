<?php 
require_once('../Connection.php');
require_once('../logic.php');
session_start();
?>

<?php 
    if(!isset($_SESSION['id'])){
        header("Location:../login.php");
    }
?>

<?php

    if(isset($_POST["submit"])){
        $filename = addslashes($_FILES['img']['name']);
        $tmpname = addslashes(file_get_contents($_FILES['img']['tmp_name']));
        $filetype = addslashes($_FILES['img']['type']);
        $filesize = addslashes($_FILES['img']['size']);

        // mysqli_query($connection1,"Insert into upload(name,image) values('{$filename}','{$tmpname}')");
        mysqli_query($connection,"UPDATE `teacher_account` SET `profile_image`= '{$tmpname}' WHERE teach_roll_id = '{$_SESSION['id']}'");
    }


?>

<?php

        if(isset($_POST["contactSubmit"])){
            $email = mysqli_real_escape_string($connection,$_POST['edgmail']);
            $mobile = mysqli_real_escape_string($connection,$_POST['edMobile']);

            switch($_SESSION['rollName']){
                case "GRADE6-11":
                case "GRADE12-13":
                    mysqli_query($connection,"UPDATE `student_account` SET `gmail`= '{$email}', `tp_number`= '{$mobile}' WHERE st_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Teacher6-11":
                case "Teacher12-13":
                    mysqli_query($connection,"UPDATE `teacher_account` SET `gmail`= '{$email}', `teach_tp_number`= '{$mobile}' WHERE teach_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Academic":
                    mysqli_query($connection,"UPDATE `other_staff_account` SET `gmail`= '{$email}', `tp_number`= '{$mobile}' WHERE 	staff_roll_id = '{$_SESSION['id']}'");
                    break;
            }
        }
        else if(isset($_POST["PersonalSubmit"])){
            $fname = mysqli_real_escape_string($connection,$_POST['edFname']);
            $maname = mysqli_real_escape_string($connection,$_POST['edMname']);
            $sname = mysqli_real_escape_string($connection,$_POST['edSname']);
            $nic = mysqli_real_escape_string($connection,$_POST['nic']);
            $address = mysqli_real_escape_string($connection,$_POST['edAddress']);
            $city = mysqli_real_escape_string($connection,$_POST['edCity']);

            switch($_SESSION['rollName']){
                case "GRADE6-11":
                case "GRADE12-13":
                    mysqli_query($connection,"UPDATE `student_account` SET `st_first_name`= '{$fname}', `st_middle_name`= '{$maname}', `st_surname`= '{$sname}', `st_nic`= '{$nic}', `address`= '{$address}', `city`= '{$city}' WHERE st_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Teacher6-11":
                case "Teacher12-13":
                    mysqli_query($connection,"UPDATE `teacher_account` SET `teach_first_name`= '{$fname}', `teach_middle_name`= '{$maname}', `teach_surname`= '{$sname}', `teach_nic`= '{$nic}', `address`= '{$address}', `teach_city`= '{$city}' WHERE teach_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Academic":
                    mysqli_query($connection,"UPDATE `other_staff_account` SET `first_name`= '{$fname}', `middle_name`= '{$maname}', `surname`= '{$sname}', `nic`= '{$nic}', `address`= '{$address}', `city`= '{$city}' WHERE staff_roll_id = '{$_SESSION['id']}'");
                    break;
            }
        }
        else if(isset($_POST["Authsubmit"])){
            $username = mysqli_real_escape_string($connection,$_POST['upUsername']);
            $password = mysqli_real_escape_string($connection,$_POST['upCPassword']);

            switch($_SESSION['rollName']){
                case "GRADE6-11":
                case "GRADE12-13":
                    mysqli_query($connection,"UPDATE `student_account` SET `username`= '{$username}', `password`= '{$password}' WHERE st_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Teacher6-11":
                case "Teacher12-13":
                    mysqli_query($connection,"UPDATE `teacher_account` SET `username`= '{$username}', `password`= '{$password}' WHERE 	teach_roll_id = '{$_SESSION['id']}'");
                    break;
                case "Academic":
                    mysqli_query($connection,"UPDATE `other_staff_account` SET `username`= '{$username}', `password`= '{$password}' WHERE 	staff_roll_id = '{$_SESSION['id']}'");
                    break;
            }
        }

        
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <script src="../../js/jquery.min.js"></script>
    <script src="../../js/croppie.min.js"></script>

    <link rel="stylesheet" href="../../css/popup.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/StudentDashboardStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/croppie.min.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/profileEditStyle.css" type="text/css" >
    <title>Document</title>
</head>
<body>
    <header>
        <div class="navigation">
            <div class="logo">
                <ul class="nav-bar">
                    <li><img src="../../resource/logo.svg" alt="Logo"></li>
                    <li><h1>LIFE LINE</h1></li>
                </ul>
            </div>
            <div class="menu">
                <h3>Sachintha Madhawa</h3>
                <p>Grade 12</p>
                <ul>
                    <li><img src="../../resource/Profile DashBoard.png" alt=""><a href="TeacherMain.php">Dashboard</a></li>
                    <li><img src="../../resource/editProfile.png" alt=""><a href="../../php/Student/profileEdit.php">Edit Profile</a></li>
                    <li><img src="../../resource/signOut.png" alt=""><a href="../logOut.php">Sign Out</a></li>
                    <!-- <li><a href="#">Logout</a></li>
                    <li><a href="#">Logout</a></li> -->
                </ul>
            </div><!--div class="menu"-->
            <div class="nav-bar">
                <nav>
                    <ul class="nav-panel">
                        <li><a href="#">Home</a></li>
                        <li><a href="#">Services</a></li>
                        <li><a href="#">About Us</a></li>
                        <li><a href="#">Contact Us</a></li>
                        <li ><a href="#" id="profile">Sign In</a></li>
                    </ul><!--ul class="nav-panel"-->
                </nav><!--nav-->
            </div><!--div class="nav-bar"-->
        </div>
    </header>

        <!-- Menu Start -->

        <nav class="side-menu">
            <ul>
                <li class="logo">
                        <a href="">
                        <div class="mProfileContainer" id="muploaded_image">
                            <div class="mpro" id="mpro">
                                
                            </div>
                        </div><!--div class="ProfileContainer"-->
                            <h1>LIFE LINE</h1></a>
                    <i><a href=""><img src="../../resource/Arrow.png" alt="" class="menu-toggle"></a></i>
                </li>
                
                <div class="menu-items">
    
                    <li class="dashboard">
                        <a href="../Teacher/TeacherMain.php" class="item list btn">
                            <i><img src="../../resource/dashBoard.png" alt=""></i>
                            <span>Dashboard</span>
                        </a>
                    </li><!--li class="dashboard"-->
        
                    <li class="News-Event">
                        <a href="" class="item list">
                            <i><img src="../../resource/Events.png" alt=""></i>
                            <span>News And Events</span>
                        </a>
                    </li><!--li class="News-Event"-->
        
                    <li class="Subjects">
                        <a href="../Teacher/TeacherGrade.php" class="item list">
                            <i><img src="../../resource/Subject.png" alt=""></i>
                            <span>Grades</span>
                        </a>
                    </li><!--li class="Subjects"-->
    
                </div><!--div class="menu-items"-->
    
            </ul>
        </nav>
    
        <!-- Menu end -->

    <div class="left-decoration">
        <div class="leftSide">
            <div class="ProfileContainer" id="uploaded_image">
                <div class="pro" id="pro">
                    
                </div>
                <form action="" method="POST">
                    <!-- <input type="file" name="upload_image" id="file" class="uploadImage" accept="image/*"> -->
                    <!-- <label type for="file" id="btnUpload">Choose Photo</label> -->
                    <!-- <input type="submit" value="submit" name="submit" style="position: absolute;"> -->
                </form>
            </div><!--div class="ProfileContainer"-->

            <div class="ProfileContainer2">
                <div class="round" id="round">
                    
                </div>
                <form action="profileEdit.php" method="POST" enctype="multipart/form-data">
                    <!-- <input type="file" name="img" id="d" class="uploadImage" accept="image/*">
                    <label for="d" id="btnUpload2">Choose ffffhoto</label>
                    <input type="submit" id="sub" name="submit" style="position: absolute;"> -->
                    <input type="file" name="img" id="d" class="uploadImage" accept="image/*">
                    <label for="d" id="btnUpload2">upload chose</label>
                    <!-- <button name="submit" id="bu"></button> -->
                    <input type="submit" name="submit" id="bu" style="position: absolute;">
                </form>
            </div>

            <div class="proUpload">
                <form action="profileEdit.php">
                    <div class="button-box">
                        <!-- <button name="PersonalSubmit" id="sub">SAVE DETAILS</button> -->
                        <label for="bu">SAVE DETAILS</label>
                    </div>
                </form>
            </div>
    
            <div class="LeftTopic">
                <h2 class="input-box" style="background-color: #273889; color: #ffff; padding: 0 70px; text-align: center; position: relative; right: 63px;">Contact Detail</h2>
           </div>
            <div class="ContactDetail" id="contactDetail">

            </div><!--div class="ContactDetail"-->
            <div class="conEdi">
                <div class="button-box">
                    <button name="ContactSubmit" id="conEdit">EDIT CONTACT DETAILS</button>
                </div>
            </div>
        </div><!--div class="leftSide"-->
    </div>

    <div class="middle">
       <div class="MiddleTopic">
            <h1 class="input-box" style="background-color: #273889; color: #ffff; padding: 0 50px; text-align: center;">Personal Details</h1>
            <p class="input-box">Lorem ipsum dolor sit amet consectetur adipisicing elit. Explicabo illum architecto velit veniam optio temporibus rerum illo 
            nihil atque repellendus impedit, fugiat, quia, tempora natus dolorem quaerat nulla odit vel.</p>
       </div>
        <div class="ProfileDetail" id="ProfileDetail">
           
        </div><!--div class="ProfileDetail"-->
        <div class="button-box">
            <button name="PersonalSubmit" id="perEdit">EDIT PERSONAL DETAILS</button>
        </div>
    </div><!--div class="middle"-->

    <div class="RightSide">

        <div class="RightTopic">
            <h2 class="input-box" style="background-color: #273889; color: #ffff; padding: 4px 70px; text-align: center; position: relative; right: 18px;">Authentication</h2>
            <p class="input-box">You must Enter the old usernsme</p>
        </div>

        <div class="ContactDetail" id="Authentication">

        </div><!--div class="ContactDetail"-->
        <div class="button-box">
            <button name="AuthenticationSubmit" id="authEdit">EDIT AUTHENTICATION</button>
        </div>
    </div><!--div class="RightSide"-->

    <div id="uploadimageModal" class="modal hide" role="dialog">

        <div class="popUpWindow ">
          <div class="overlay"></div>
      
          <div id="popup">
            <div class="popup-content ">
              <div class="btnClose">
                  <img src="../resource/close.png" alt="" id="close-btn">
                  <!-- <img src="/php/Student/StudentMain.html" alt="" id="close-btn"> -->
              </div>
      
              <div >
                <button type="button" class="close" data-dismiss="modal">×</button>
                <h4 >Upload & Crop Image</h4>
              </div>
      
              <div id="croppie-Frame" class="croppie-Frame">
                <div id="image_demo" style="width:350px; margin-top:30px"></div>
              </div>
      
              <button class="crop_image">Crop & Upload Image</button>
                  
            </div><!--div class="popup-content"-->
          </div><!--div id="popup"-->
        </div><!--div class="popUpWindow"-->
      
      </div><!--div id="uploadimageModal" class="modal" role="dialog"-->

      <div class="contact-details hide" id="contact-details">

        <div class="form-update">
            
            <div class="overlay"></div>

        <div id="popup1">
            <div class="cDetail">
                <div class="closeBtn">
                    <img src="../../resource/close.png" alt="" id="conClose">
                </div>
                <div class="inner-box">
                <div class="con-topic">UPDATE YOUR <br/>CONTACT DETAILS</div>
                    <form action="profileEdit.php" method="post" id="contactForm">
                        <div class="input-box">
                            <input type="text"  name="edgmail" id="email">
                            <span class="floatingLabel">Gmail</span>
                            <label for="" class="error" id="gmailError"></label>
                        </div>
                        <div class="input-box">
                            <input type="text" name="edMobile" id="mobile">
                            <span class="floatingLabel">Mobile Number</span>
                            <label for="" class="error"></label>
                        </div>
                        <div class="button-box signin-button-box">
                            <button name="contactSubmit">SAVE DETAILS</button>
                        </div>
                    </form>
                </div>
            </div><!--div class="conDetail"-->
        </div><!--div id="popup"-->

        </div><!--div class="form-update"-->

      </div><!--div class="contact-details"-->


      <div class="personal-details hide">

        <div class="form-update">
            
            <div class="overlay"></div>

        <div id="popup2">
            <div class="pDetail">
                <div class="closeBtn">
                    <img src="../../resource/close.png" alt="" id="perClose">
                </div>
                <div class="inner-box">
                <div class="per-topic">UPDATE YOUR <br/>PROFILE DETAILS</div>
                    <form action="profileEdit.php" method="post" id="profileForm">
                            <div class="input-group d-flex">
                                <div class="input-box">
                                    <input type="text" name="edFname" id="edFname">
                                    <span class="floatingLabel">First Name</span>
                                    <label for=""></label>
                                </div>
                                <div class="input-box">
                                    <input type="text" name="edMname" id="edMname">
                                    <span class="floatingLabel">Middle Name</span>
                                    <label for=""></label>
                                </div>
                                <div class="input-box">
                                    <input type="text" name="edSname" id="edSname">
                                    <span class="floatingLabel">Surname</span>
                                    <label for=""></label>
                                </div>
                            </div>
                            <div class="input-group d-flex">
                                <div class="input-box">
                                    <input type="text" name="nic" id="nic">
                                    <span class="floatingLabel">National Id Number</span>
                                    <label for=""></label>
                                </div>
                                <div class="input-box">
                                    <span class="">Lorem ipsum dolor sit amet consectetur<br> adipisicing elit. Repellendus, voluptatibus!</span>
                                </div>
                            </div>
                            <div class="input-group d-flex">
                                <div class="input-box">
                                    <input type="text" name="edAddress" id="edAddress">
                                    <span class="floatingLabel">Address</span>
                                    <label for=""></label>
                                </div>
                                <div class="input-box">
                                    <input type="text" name="edCity" id="edCity">
                                    <span class="floatingLabel">city</span>
                                    <label for=""></label>
                                </div>
                            </div>
                            <div class="button-box">
                                <button name="PersonalSubmit">SAVE DETAILS</button>
                            </div>
                    </form>
                </div>
            </div><!--div class="conDetail"-->
        </div><!--div id="popup"-->

        </div><!--div class="form-update"-->

      </div><!--div class="personal-details"-->


      <div class="Authen-details hide">

        <div class="form-update">
            
            <div class="overlay"></div>

        <div id="popup3">
            <div class="aDetail">
                <div class="closeBtn">
                    <img src="../../resource/close.png" alt="" id="auClose">
                </div>
                <div class="inner-box">
                <div class="auth-topic">UPDATE YOUR<br>AUTHENTICATION</div>
                    <form action="profileEdit.php" method="post" id="authForm">
                        <div class="input-box">
                            <input type="text" name="upUsername" id="upUsername">
                            <span class="floatingLabel">Username</span>
                        </div>
                        <div class="input-box">
                            <input type="text" name="upPassword" id="upPassword">
                            <span class="floatingLabel">Password</span>
                            <label for=""></label>
                        </div>
                        <div class="input-box">
                            <input type="text" name="upCPassword" id="upCPassword">
                            <span class="floatingLabel">Comfirm Password</span>
                        </div>
                        <div class="button-box signin-button-box">
                            <button name="Authsubmit">SAVE DETAILS</button>
                        </div>
                    </form>
                </div>
            </div><!--div class="conDetail"-->
        </div><!--div id="popup"-->

        </div><!--div class="form-update"-->

      </div><!--div class="contact-details"-->
    
      <script src="../../js/Student/updateForms.js"></script>
    <script>
        function loadXmlDoc(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('pro').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","ProfilePic.php",true);
            xhttp.send();
        }

        function sideBar(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('mpro').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","ProfilePic.php",true);
            xhttp.send();
        }

        function leftSide(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('contactDetail').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","ContactDetail.php",true);
            xhttp.send();
        }

        function middleSide(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('ProfileDetail').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","ProfileDetail.php",true);
            xhttp.send();
        }

        function rightSide(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('Authentication').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","Authentication.php",true);
            xhttp.send();
        }

        setInterval(() => {
            loadXmlDoc();
            leftSide();
            middleSide();
            rightSide();
            sideBar();
        }, 1000);
        
        
    </script>
    <script src="../../js/Student/studentProfile.js"></script>
    <script src="../../js/profileUpload.js"></script>
    <script src="../../js/Student/StudentMenu.js"></script>
    <script src="../../js/formValidation.js"></script>
</body>
</html>