function UnityProgress(unityInstance, progress)
{
  if (!unityInstance.Module)
    return;

   
  
    if (!unityInstance.progress)
    {
      unityInstance.progress = document.getElementById("custom-loader");
      unityInstance.progress.style.display = "block";
      unityInstance.container.appendChild(unityInstance.progress);
    }
  
    setLoaderProgressTo(progress);
  
    if (progress == 1)
    {
     
      unityInstance.progress.style.display = "none";
    }
  
  
  // value - 0 to 1
  function setLoaderProgressTo(value)
  {
    const fill = unityInstance.progress.getElementsByClassName("fill")[0];
   // console.log(window.innerWidth);
    fill.animate(
      [ 
        { width: (value * (1/window.innerWidth)*1000) + "%" }
      ],
      {
       
        fill: "forwards"
      }
    );
  }
   
}