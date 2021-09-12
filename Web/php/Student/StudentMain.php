<?php 
require_once('../Connection.php');
include('../logic.php'); 
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

<?php 

    $attCount = (int)getRowCount("SELECT COUNT(*) as count FROM `student_attendance` WHERE student_ID = '{$_SESSION['id']}'");

?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/StudentDashboardStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/AllStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/studentMainChartStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/dashBoardSubjectIEntress.css" type="text/css">
    <link rel="stylesheet" href="../../css/ScrollAdd.css" type="text/css">

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
        <script type="text/javascript">
        google.charts.load("current", {packages:["corechart"]});
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Task', 'Hours per Day'],
                ['English', 75],
                ['Science', 76],
                ['Maths', 96],
                ['Sinhala', 78],
                ['Religion', 80],
                ['History', 77],
                ['<?php echo $basket1Name ?>', 82],
                ['<?php echo $basket2Name ?>', 91],
                ['<?php echo $basket3Name ?>', 98]
            ]);

            var options = {
            title: 'Exam Results',
            pieHole: 0.3,
            titleTextStyle: { fontSize: 20,color: '#7b7b7b' },
            slices: {
                0: { color: '#273889' },
                1: { color: '#45AAB4' },
                2: { color: '#038DB2' },
                3: { color: '#206491' },
                4: { color: '#FBB45C' },
                5: { color: '#FE7966' },
                6: { color: '#F9637C' },
                7: { color: '#00949D' },
                8: { color: '#646589' }
            }
            };

            var chart = new google.visualization.PieChart(document.getElementById('countDownload'));
            chart.draw(data, options);
        }
    </script>

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
                    <a href="../Student/StudentSubject.php" class="item list">
                        <i><img src="../../resource/Subject.png" alt=""></i>
                        <span>Subjects</span>
                    </a>
                </li><!--li class="Subjects"-->

            </div><!--div class="menu-items"-->

        </ul>
    </nav>

    <!-- Menu end -->

    <div class="page-wrapper">

        <div class="allBox">

            <div class="welcome-area">
                <div class="stdash1">
                    <img src="../../resource/studentDash1.png" alt="" id="stdash1">
                </div>
                <img src="../../resource/studentDash.svg" alt="" id="stdash2">
            </div><!--div class="welcome-area"-->


            <div class="prgrssEvents">

                <div class="progress PEbox">
                    <h3>Your Progress</h3>
                    <div class="subectWithProgrss">
                        <div class=" sub Eng">
                            <a href="#" class="subectProgress">English</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">

                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class=" sub Eng"-->

                        <div class="sub Sci">
                            <a href="#" class="subectProgress">Science</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub Sci"-->

                        <div class="sub Math">
                            <a href="#" class="subectProgress">Maths</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub Math"-->

                        <div class="sub Sinhala">
                            <a href="#" class="subectProgress">Sinhala</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress">-->
                        </div><!--div class="sub Sinhala"-->

                        <div class="sub Religion">
                            <a href="#" class="subectProgress">Religion</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub Religion"-->

                        <div class="sub Hist">
                            <a href="#" class="subectProgress">History</a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub Hist"-->

                        <div class="sub group1">
                            <a href="#" class="subectProgress"><?php echo $basket1Name ?></a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub group1"-->

                        <div class="sub group2">
                            <a href="#" class="subectProgress"><?php echo $basket2Name ?></a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress">-->
                        </div><!--div class="sub group2"-->

                        <div class="sub group3">
                            <a href="#" class="subectProgress"><?php echo $basket3Name ?></a>
                            <div class="progress subectProgress">
                                <div class="progress-done">
                                    
                                </div><!--div class="progress-done"-->
                            </div><!--div class="progress subectProgress"-->
                        </div><!--div class="sub group3"-->

                    </div><!--div class="subectWithProgrss"-->
                </div><!--div class="progress PEbox"-->
    
                <div class="Events PEbox">
                    <div class="alertBox" style="background-color: #094C9B;">
                        <h3>Today Exams</h3>
                        <p>The maths exam will be held on 1pm - 3pm"</p>
                    </div>
                    <div class="alertBox" style="background-color: #206491;">
                        <h3>Today Exams</h3>
                        <p>The maths exam will be held on 1pm - 3pm"</p>
                    </div>
                    <div class="alertBox" style="background-color: #094C9B">
                        <h3>Today Exams</h3>
                        <p>The maths exam will be held on 1pm - 3pm"</p>
                    </div>
                    <div class="alertBox" style="background-color: #206491;">
                        <h3>Today Exams</h3>
                        <p>The maths exam will be held on 1pm - 3pm"</p>
                    </div>
                </div><!--div class="Events"-->
                

            </div><!--div class="prgrssEvents"-->

            <div class="RankAttendance">
                <div class="iconRank"><img src="../../resource/attendance.png" alt=""></div>
                <div class="rnkTopic">
                    <h4>Rank</h4>
                    <h5>00</h5>
                </div>
                <div class="rank">
                    <img src="../../resource/rank.png" alt="">
                </div><!--div class="rank"-->

                <div class="iconAttendance"><img src="../../resource/attendance.png" alt=""></div>
                <div class="attenTopic">
                    <h4>Attendace</h4>
                    <h5><?php echo $attCount; ?></h5>
                </div>
                <div class="attendance">
                    <img src="../../resource/rank.png" alt="">
                </div><!--div class="attendance"-->

            </div><!--div class="RankAttendance"-->

        </div><!--div class="allBox"--> 

        <div class="chartUsingDownload" id="countDownload"></div>

        <div class="subjectsEntres">
            <div class="StSubjects">
                <div class="subjectTopic">
                    <h1>All Subjects</h1>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. <br>Et, libero?</p>
                </div>
                <div class="allSub">
                    <div class="sub Eng" >
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0005">
                            <h1>English</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Eng"-->
        
                    <div class="sub Sci">
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0004">
                            <h1>Science</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Sci"-->
        
                    <div class="sub Math">
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0006">
                            <h1>Maths</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Math"-->
        
                    <div class="sub Sinhala">
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0001">
                            <h1>Sinhala</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Sinhala"-->
        
                    <div class="sub Religion">
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0002">
                            <h1>Religion</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Religion"-->
        
                    <div class="sub Hist">
                        <a href="../Assigment/StudentSubInside.php?subId=SUB0003">
                            <h1>History</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub Hist"-->
        
                    <div class="sub group1">
                        <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket1 ?>">
                            <h1><?php echo $basket1Name ?></h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub group1"-->
        
                    <div class="sub group2">
                        <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket2 ?>">
                            <h1><?php echo $basket2Name ?></h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub group2"-->
        
                    <div class="sub group3">
                        <a href="../Assigment/StudentSubInside.php?subId=<?php echo $basket3 ?>">
                            <h1><?php echo $basket3Name ?></h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div><!--div class="sub group3"-->
                </div>
        </div><!--div class="subjectsEntres"-->

        <div class="space"></div>

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

    <script src="../../js/Student/StudentMenu.js"></script>
    <script src="../../js/Student/studentProfile.js"></script>
</body>
</html>