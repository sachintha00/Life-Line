const contactForm = document.getElementById('contactForm');
const email = document.getElementById('email');
const mobile = document.getElementById('mobile');

contactForm.addEventListener('submit',(e)=>{
    const emailvalue = email.value.trim();
    const mobilevalue = mobile.value.trim();
    if(emailvalue === ''){
        e.preventDefault();
        setFormError(mobile,"");
        setFormError(mobile,"Please check your mobile Number");
    }
    else if(mobilevalue === ''){
        e.preventDefault();
        setFormError(email,"");
        setFormError(email,"Please check your Email");
    }
    
});

const profileForm = document.getElementById('profileForm');
const fname = document.getElementById('edFname');
const mname = document.getElementById('edMname');
const sname = document.getElementById('edSname');
const nic = document.getElementById('nic');
const address = document.getElementById('edAddress');
const city = document.getElementById('edCity');

profileForm.addEventListener('submit',(e)=>{
    const fnameValue = fname.value.trim();
    const mnameValue = mname.value.trim();
    const snameValue = sname.value.trim();
    const nicValue = nic.value.trim();
    const addressValue = address.value.trim();
    const cityValue = city.value.trim();

    if(fnameValue === ''){
        e.preventDefault();
        setFormError(mname,"");
        setFormError(sname,"");
        setFormError(nic,"");
        setFormError(address,"");
        setFormError(city,"");
        setFormError(fname,"please enter valid input");
    }
    else if(mnameValue === ''){
        e.preventDefault();
        setFormError(fname,"");
        setFormError(sname,"");
        setFormError(nic,"");
        setFormError(address,"");
        setFormError(city,"");
        setFormError(mname,"please enter valid input");
    }
    else if(snameValue === ''){
        e.preventDefault();
        setFormError(fname,"");
        setFormError(mname,"");
        setFormError(nic,"");
        setFormError(address,"");
        setFormError(city,"");
        setFormError(sname,"please enter valid input");
    }
    else if(nicValue === ''){
        e.preventDefault();
        setFormError(fname,"");
        setFormError(mname,"");
        setFormError(sname,"");
        setFormError(address,"");
        setFormError(city,"");
        setFormError(nic,"please enter valid input");
    }
    else if(addressValue === ''){
        e.preventDefault();
        setFormError(fname,"");
        setFormError(mname,"");
        setFormError(sname,"");
        setFormError(nic,"");
        setFormError(city,"");
        setFormError(address,"please enter valid input");
    }
    else if(cityValue === ''){
        e.preventDefault();
        setFormError(fname,"");
        setFormError(mname,"");
        setFormError(sname,"");
        setFormError(nic,"");
        setFormError(address,"");
        setFormError(city,"please enter valid input");
    }
    
});


const authenForm = document.getElementById('authForm');
const username = document.getElementById('upUsername');
const paswword = document.getElementById('upPassword');
const cpassword = document.getElementById('upCPassword');

authenForm.addEventListener('submit',(e)=>{
    const usernameValue = username.value.trim();
    const paswwordValue = paswword.value.trim();
    const cpasswordValue = cpassword.value.trim();
    if(usernameValue === ''){
        e.preventDefault();
    }
    else if(paswwordValue === '' && cpasswordValue === ''){
        e.preventDefault();
        setFormError(paswword,"please check your password againt");
    }
    else if(paswwordValue !== cpasswordValue ){
        e.preventDefault();
        setFormError(username,"");
        setFormError(paswword,"please check your password againt");
    }
    
});



function setFormError(input,message){
    const formControl = input.parentElement;
    const label = formControl.querySelector('label');

    label.innerText = message;
}