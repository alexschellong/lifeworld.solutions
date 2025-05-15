const PDFClick = () => {
  const link = document.createElement('a');
  link.href = "./TemplateData/portfolio_alex-schellong.pdf";
  link.target = "_blank";
  link.contentType = "application/pdf";
  link.click();
  link.remove();
};

const threeDClick = () => {
  alert("3D experience is not supported on mobile devices :(");
};

if (window.matchMedia("(any-hover: none)").matches) {

  // Phone/touch device code
  document.addEventListener('DOMContentLoaded', function () {

    const screenHeight = window.screen.height;
    const screenWidth = window.screen.width;
    const threeDTop = (55 * (1300 / screenHeight));
    const pdfTextTop = (55 * (1400 / screenHeight));

    const threeDFontSize = Math.min(screenWidth, screenHeight) / 3;
    const pdfFontSize = Math.min(screenWidth, screenHeight) / 5;

    const textThreeD = document.createElement('p');
    textThreeD.textContent = "3D";
    textThreeD.classList.add("text");
    textThreeD.style.fontSize = `${threeDFontSize}px`;
    textThreeD.style.letterSpacing = `5px`;
    textThreeD.style.left = `50vw`;
    textThreeD.style.transform = `translate(-50%, -50%)`;
    textThreeD.style.top = `calc(50.5dvh - ${threeDTop}px)`;
    document.body.appendChild(textThreeD);
    textThreeD.addEventListener('click', threeDClick);

    const pdfText = document.createElement('p');
    pdfText.textContent = "PDF";
    pdfText.classList.add("text");
    pdfText.style.fontSize = `${pdfFontSize}px`;
    pdfText.style.left = `50vw`;
    pdfText.style.transform = `translate(-50%, -50%)`;
    pdfText.style.top = `calc(50dvh + ${pdfTextTop}px)`;
    document.body.appendChild(pdfText);
    pdfText.addEventListener('click', PDFClick);

    const PDFdivContainerDiv = document.createElement('div');
    PDFdivContainerDiv.style.display = "block";
    PDFdivContainerDiv.classList.add("PDFdivContainer");
    PDFdivContainerDiv.style.pointerEvents = 'none';
    document.body.appendChild(PDFdivContainerDiv);

    const backgroundDivPDF1 = document.createElement('div');
    backgroundDivPDF1.classList.add("backgroundDiv", "PDF");
    PDFdivContainerDiv.appendChild(backgroundDivPDF1);

    const insideDivPDFUp = document.createElement('div');
    insideDivPDFUp.classList.add("insideDivPDF", "Upper");
    backgroundDivPDF1.appendChild(insideDivPDFUp);

    const backgroundDivPDF2 = document.createElement('div');
    backgroundDivPDF2.classList.add("backgroundDiv", "PDF");
    PDFdivContainerDiv.appendChild(backgroundDivPDF2);

    PDFdivContainerDiv.appendChild(backgroundDivPDF2);
    const insideDivPDFDown = document.createElement('div');
    insideDivPDFDown.classList.add("insideDivPDF", "Lower");
    backgroundDivPDF2.appendChild(insideDivPDFDown);
  });


} else {

  // PC code
  document.addEventListener('DOMContentLoaded', function () {
    const textThreeD = document.createElement('p');
    textThreeD.textContent = "3D";
    textThreeD.classList.add("text", "threeD");
    document.body.appendChild(textThreeD);

    const pdfText = document.createElement('p');
    pdfText.textContent = "PDF";
    pdfText.classList.add("text", "pdf");
    document.body.appendChild(pdfText);


    const backgroundDiv = document.createElement('div');
    backgroundDiv.classList.add("backgroundDiv");
    document.body.appendChild(backgroundDiv);

    const line = document.createElement('hr');
    line.classList.add("line");
    backgroundDiv.appendChild(line);

    const PDFdivContainerDiv = document.createElement('div');
    PDFdivContainerDiv.classList.add("PDFdivContainer");
    document.body.appendChild(PDFdivContainerDiv);

    const backgroundDivPDF1 = document.createElement('div');
    backgroundDivPDF1.classList.add("backgroundDiv", "PDF");
    PDFdivContainerDiv.appendChild(backgroundDivPDF1);

    const insideDivPDFUp = document.createElement('div');
    insideDivPDFUp.classList.add("insideDivPDF", "Upper");
    backgroundDivPDF1.appendChild(insideDivPDFUp);

    const backgroundDivPDF2 = document.createElement('div');
    backgroundDivPDF2.classList.add("backgroundDiv", "PDF");
    PDFdivContainerDiv.appendChild(backgroundDivPDF2);

    PDFdivContainerDiv.appendChild(backgroundDivPDF2);
    const insideDivPDFDown = document.createElement('div');
    insideDivPDFDown.classList.add("insideDivPDF", "Lower");
    backgroundDivPDF2.appendChild(insideDivPDFDown);

    const backgroundImg = document.createElement('img');
    backgroundImg.src = "TemplateData/backgroundImg.jpg";
    backgroundImg.classList.add("backgroundImg");
    document.body.appendChild(backgroundImg);

    const loadingText = document.createElement('p');
    loadingText.textContent = "Loading";
    loadingText.classList.add("text", "loading");
    document.body.appendChild(loadingText);

    const unityContainer = document.createElement('div');
    unityContainer.id = "unityContainer";
    document.body.appendChild(unityContainer);


    // Scripts
    const unitySuccess = document.createElement('script');
    unitySuccess.src = "./scripts/UnitySuccess.js";
    unitySuccess.type = "module";
    document.body.appendChild(unitySuccess);

    const unityLoader = document.createElement('script');
    unityLoader.src = "./Build/UnityLoader.js";
    document.body.appendChild(unityLoader);

    const code = `import { UnitySuccessFunc } from './scripts/UnitySuccess.js';
          var unityInstance = UnityLoader.instantiate("unityContainer", "Build/web.json", {onProgress: UnitySuccessFunc});`

    const unityLoaderLoad = document.createElement('script');
    unityLoaderLoad.defer = true;
    unityLoaderLoad.type = "module";
    unityLoaderLoad.textContent = code;
    document.body.appendChild(unityLoaderLoad);


    const hoverAndClickScript = document.createElement('script');
    hoverAndClickScript.src = "./scripts/HoverAndClick.js";
    hoverAndClickScript.defer = true;
    hoverAndClickScript.type = "module";
    document.head.appendChild(hoverAndClickScript);
  });
}
