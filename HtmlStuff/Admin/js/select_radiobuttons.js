$(document).ready(
function()
    {
        $(".item").click(
            function(event)
        {
            $(this).addClass("active").siblings().removeClass("active");
        }
        );
    });