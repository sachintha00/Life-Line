var form1 = document.getElementById("form1");
var form2 = document.getElementById("form2");
var form3 = document.getElementById("form3");

var backSignIn = document.getElementById("btnbackSignIn");
var signUpbtn = document.getElementById("btnSignUp");

var headLine = document.querySelector(".logo-and-back");


function backToLoggin(formStyleId)
{
    document.getElementById("image1").style.transform = "scale(0)";
    document.getElementById("formStyle2").style.width = "55%";
    document.getElementById("formStyle2").style.left = "-1px";
    document.getElementById(formStyleId).style.transform = "scale(0)";
    backSignIn.style.transform = "scale(0)";
    document.getElementById("image2").style.transform = "scale(1)";
    document.getElementById("btnbackSignIn").style.transform = "scale(1)"; 
}


backSignIn.onclick = function(){
    if(document.getElementById("FormStyle1").style.transform == "scale(1)")
        backToLoggin("FormStyle1");
    else if(document.getElementById("FormStyleteach").style.transform == "scale(1)")
        backToLoggin("FormStyleteach");
}

function scalingSignupCommnItem()
{   
    setTimeout(()=> {
        document.getElementById("image1").style.transform = "scale(1)";   
        backSignIn.style.transform = "scaleY(1)";
        headLine.classList.add("new-logo-and-back");
     },1300);

    btnbackSignInHide();
    document.getElementById("formStyle2").style.width = "44.9%";
    document.getElementById("formStyle2").style.left = "81.9vh";
}

signUpbtn.addEventListener("click",()=>{
    
    var signUpButtonList = document.querySelector(".btn-list");
    signUpButtonList.classList.toggle("new-multi-register-show");

    var btnList = document.getElementsByClassName("multi-register");
    for(var i=0; i<btnList.length; i++)
    {
        if(i==0)
        {
            btnList[0].addEventListener("click",()=>{      
                signUpButtonList.classList.remove("new-multi-register-show");
                scalingSignupCommnItem();
                setTimeout(()=>{document.getElementById("FormStyle1").style.transform = "scale(1)";},500);
                document.getElementById("image2").style.transform = "scale(0)";
            });
        }
        else if(i==1)
        {
            btnList[1].addEventListener("click",()=>{      
                signUpButtonList.classList.remove("new-multi-register-show");
                scalingSignupCommnItem();
                setTimeout(()=>{document.getElementById("FormStyleteach").style.transform = "scale(1)";},500);
                document.getElementById("image2").style.transform = "scale(0)";
            });
        }
        else
        {
            btnList[2].addEventListener("click",()=>{      
                signUpButtonList.classList.remove("new-multi-register-show");
                scalingSignupCommnItem();
                setTimeout(()=>{document.getElementById("FormStyle1").style.transform = "scale(1)";},500);
                document.getElementById("image2").style.transform = "scale(0)";
            });
        }
    }
    
});

document.getElementById("btnNext1").addEventListener("click",()=>{
    document.getElementById("form1").style.position = "absolute";
    document.getElementById("form1").style.left = "-80vh"
    document.getElementById("form2").style.position = "relative";
    document.getElementById("form2").style.left = "0";
})

document.getElementById("btnNext2").addEventListener("click",()=>{
    document.getElementById("form2").style.position = "relative";
    document.getElementById("form2").style.left = "-80vh"
    document.getElementById("form3").style.position = "relative";
    document.getElementById("form3").style.left = "0";
})

document.getElementById("btnBack1").addEventListener("click",()=>{
    document.getElementById("form1").style.position = "absolute";
    document.getElementById("form1").style.left = "0"
    document.getElementById("form2").style.position = "relative";
    document.getElementById("form2").style.left = "110vh";
})

document.getElementById("btnBack2").addEventListener("click",()=>{
    document.getElementById("form2").style.position = "relative";
    document.getElementById("form2").style.left = "0"
    document.getElementById("form3").style.position = "relative";
    document.getElementById("form3").style.left = "110vh";
})

function btnbackSignInHide()
{
    backSignIn.addEventListener("click",()=>{
        backSignIn.style.transform = "scaleY(0)";
        headLine.classList.remove("new-logo-and-back");
    });
}