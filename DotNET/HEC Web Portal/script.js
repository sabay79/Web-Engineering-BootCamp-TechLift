//Set iFrame Height //
function resizeIframe() {

   //obj.style.height = obj.contentWindow.document.body.scrollHeight + 'px';
   $('iframe').height($('iframe').contents().height());

 }
 //Input Masking
 $(':input').inputmask();


$(document).ready(function(){
  document.getElementById('contactDetails').style.display = "none";
});
$(document).ready(function(){
  document.getElementById('educationDetails').style.display = "none";
});
//Show-Toggle section on button click - Plus   Button //

//Show Education Details div on click
function showSection(sectionID)
{
  document.getElementById(sectionID).style.display = "block";
}

//Hide section on Button Click - Cancel Button //
function hideSection(sectionID){
  let sectionToHide = document.getElementById(sectionID);
  sectionToHide.style.display = "none";
}




// function openContactDetails()
// {
//   var x = document.getElementById("contact_details");
//   if (x.style.display === "none") {
//     x.style.display = "block";
//   } else {
//     x.style.display = "none";
//   }
// }

//Print value on Input Field //

let fullname = document.getElementById("fullname");
let firstName = document.getElementById('fname').value;
let middleName = document.getElementById('mname').value;
let lastName = document.getElementById('lname').value;
fullname.value = firstName + ' ' + middleName + ' ' + lastName;

function generateFullName(){
  document.getElementById("fullname").value = 
  document.getElementById("fname").value + " " +
  document.getElementById("mname").value + " " +
  document.getElementById("lname").value;
}

//Check condition//
function updateGradingSystem()
{
  let totalGrade = document.getElementById("totalGradeLabel");
  let obtainedGrade = document.getElementById("obtainedGradeLabel");

  if (document.getElementById('cgpaGrading').checked == true) 
  {
    totalGrade.innerText = "Total CGPA";
    obtainedGrade.innerHTML = "Obtained CGPA";
  }
  if (document.getElementById('marksGrading').checked == true) 
  {
    totalGrade.innerText = "Total Marks";
    obtainedGrade.innerHTML = "Obtained Marks";
  }
  if (document.getElementById('percentageGrading').checked == true) 
  {
    totalGrade.innerText = "Total Percentage";
    obtainedGrade.innerHTML = "Obtained Percentage";
  }
}

//Validation on button click //


























 //$("#CNIC").inputmask("99999-9999999-9");

 //$("#phone").inputmask({"mask": "(999) 999-9999"});



// $('#nav-personal-tab').on('click', function(event) {        
//    document.getElementById("nav-personal").setAttribute('hidden', false)
// });

// $('#nav-contact-tab').on('click', function(event) {        
//    document.getElementById("nav-contact").setAttribute('hidden', false)
// });

// $('#nav-edu-tab').on('click', function(event) {        
//    document.getElementById("nav-edu").setAttribute('hidden', false)
// });

// $('#nav-emp-tab').on('click', function(event) {        
//    document.getElementById("nav-emp").setAttribute('hidden', false)
// });

// $(".tab").click(function () {
//     $(".tab").removeClass("active");
//     // $(".tab").addClass("active"); // instead of this do the below 
//     $(this).addClass("active");   
// });

// $('#about').setAttribute('hidden', true)