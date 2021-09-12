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

    $result_set = mysqli_query($connection,"SELECT * FROM student_subject WHERE st_roll_id = '{$_SESSION['id']}'");
    
    while($result = mysqli_fetch_assoc($result_set)){
        $result_set2 = mysqli_query($connection,"SELECT * FROM subject WHERE subject_id = '{$result['subject_id']}'");
        while($result2 = mysqli_fetch_assoc($result_set2)){
            if($result2['subject_roll'] == 'BASKET1(O/L)'){
                $basket1 = $result2['subject_id'];
                $basket1Name = $result2['subject'];
                break;
            }
            if($result2['subject_roll'] == 'BASKET2(O/L)'){
                $basket2 = $result2['subject_id'];
                $basket2Name = $result2['subject'];
                break;
            }
            if($result2['subject_roll'] == 'BASKET3(O/L)'){
                $basket3 = $result2['subject_id'];
                $basket3Name = $result2['subject'];
                break;
            }
        }
    }

    ?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/StudentSubject.css" type="text/css">
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
                <!-- <h3>Sachintha Madhawa</h3>
                <p>Grade 12</p> -->
                <ul>
                    <li><img src="../../resource/Profile DashBoard.png" alt=""><a href="StudentMain.php">Dashboard</a></li>
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
                        <li><a href="#">Library</a></li>
                        <li ><a href="#" class="SignIn-Nav" id="profile">Sign In</a></li>
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
                    <a href="../Student/StudentMain.php" class="item list btn">
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
                    <a href="../Student/StudentSubject.html" class="item list">
                        <i><img src="../../resource/Subject.png" alt=""></i>
                        <span>Subjects</span>
                    </a>
                </li><!--li class="Subjects"-->

            </div><!--div class="menu-items"-->

        </ul>
    </nav>

    <!-- Menu end -->

    <div class="topicAndDescript">
        <h1>SUBJECT SECTION</h1>
        <p>All the activities related to the subjects can be done in this</p>
    </div><!--div class="topicAndDescript"-->


    <div class="page-wrapper">

        <div class="StSubjects">
            <div class="subjectTopic">
                <h1>All Subjects</h1>
                <p>Contains all the subjects you have chosen and are entitled to.<br>Enter the relevant subject and perform the tasks relevant to you.</p>
            </div>
            <div class="allSub">
                <div class="sub Eng" >
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0005">
                        <h1>English</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Eng"-->
    
                <div class="sub Sci">
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0004">
                        <h1>Science</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Sci"-->
    
                <div class="sub Math">
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0006">
                        <h1>Maths</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Math"-->
    
                <div class="sub Sinhala">
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0001">
                        <h1>Sinhala</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Sinhala"-->
    
                <div class="sub Religion">
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0002">
                        <h1>Religion</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Religion"-->
    
                <div class="sub Hist">
                    <a href="../Assigment/StudentSubInside.php?subId=SUB0003">
                        <h1>History</h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Hist"-->
    
                <div class="sub group1">
                    <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket1 ?>">
                        <h1><?php echo $basket1Name ?></h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub group1"-->
    
                <div class="sub group2">
                    <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket2 ?>">
                        <h1><?php echo $basket2Name ?></h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub group2"-->
    
                <div class="sub group3">
                    <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket3 ?>">
                        <h1><?php echo $basket3Name ?></h1>
                        <p>Click on this <br> enter the subject</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub group3"-->
            </div>

        </div><!--div class="Subjects"-->

        <div class="ExamTimeTable">
            <div class="tableName">
                <h1>ALL ASSIGNMENTS</h1>
            </div>
            <div class="input-box">
                <input type="text" required="" name="username">
                <span class="floatingLabel">Search</span>
            </div>
            <div class="tableStyle">
                <table class="content-tabel">
                    <thead>
						<tr>
							<th>Assignment NO</th>
							<th>Assignment Name</th>
							<th>Student ID</th>
							<th>Student Name</th>
						</tr>
					</thead>
                    <tbody>
                    <?php
                        // $result_set = getResultSet("SELECT * FROM `student_assignment_upload` WHERE subject_id = '{$_GET['subId']}'");

                        // foreach($result_set as $result){
                        //     $result2 = getValue("SELECT * FROM student_account WHERE `st_roll_id` = '{$result['student_ID']}'");                                          
                        //     $srudentName = $result2['st_first_name']." ".$result2['st_middle_name'];   
                    ?>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    <?php    ?>
                    </tbody>
                </table>
            </div>
        </div><!--div class="ExamTimeTable"-->

        <div class="alertMessageSubject">
            <div class="alertTopic">
                <h1>Alert</h1>
                <p>New Alert</p>
            </div>

            <div class="alert">
                <div>
                    <h2>Head Line</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi, tempore!</p>
                </div><!--div class="sub Eng"-->
            </div>
            <div class="alert">
                <div>
                    <h2>Head Line</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi, tempore!</p>
                </div><!--div class="sub Eng"-->
            </div>

        </div>

        <div class="downloadTimeTable">
            <div class="input-box">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Est, similique?</p>
                <button name="downloadTimeTable" id="downloadTimeTable">Download Time Table</button>
            </div>
        </div>

    </div><!--div class="page-wrapper"-->

    <script>

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

        setInterval(() => {

            sideBar();
        }, 1000);
        
        
    </script>

    <script src="../../js/Student/studentProfile.js"></script>
    <script src="../../js/Student/StudentMenu.js"></script>
</body>
</html>