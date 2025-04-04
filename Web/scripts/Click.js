import { unityLoaded } from "./UnitySuccess.js";

const portfolioPDF = "/TemplateData/portfolio_alex-schellong.pdf"

export let unityReady = false;

let pdfIframe;
let downloadText;
let threeDExperienceText;
const unityContainer = document.getElementById('unityContainer');


const DownloadFunc = () => {
    const downloadLink = document.createElement('a');
    downloadLink.href = portfolioPDF;
    downloadLink.download = 'portfolio_alex-schellong.pdf';
    downloadLink.click();
    downloadLink.remove();
}

export const threeDExperienceFunc = (threeDButton, pdfButton, backgroundImg, loadingText, backgroundDiv, PDFdivContainer, mainMenu) => {

    if (mainMenu == true) {
        threeDButton.remove();
        pdfButton.remove();
        backgroundDiv.remove();
        PDFdivContainer.remove();
    } else {
        pdfIframe.remove();
        threeDExperienceText.remove();
        downloadText.remove();
    }

    if (unityLoaded == true) {
        unityContainer.style.display = 'block';
        backgroundImg.remove();
        loadingText.remove();
    } else {

        backgroundImg.style.display = 'block';
        loadingText.style.display = 'block';

        unityReady = true;
    }
}

export const PDFClick = (threeDButton, pdfButton, backgroundImg, loadingText, backgroundDiv, PDFdivContainer) => {
    threeDButton.remove();
    pdfButton.remove();
    backgroundDiv.remove();
    PDFdivContainer.remove();

    backgroundImg.style.display = "block";

    pdfIframe = document.createElement('iframe');
    pdfIframe.src = portfolioPDF;
    pdfIframe.style.position = 'fixed';
    pdfIframe.style.top = '60px';
    pdfIframe.style.left = '50px';
    pdfIframe.style.right = '50px';
    pdfIframe.style.bottom = '50px';
    pdfIframe.style.width = 'calc(100% - 100px)';
    pdfIframe.style.height = 'calc(100% - 100px)';
    document.body.appendChild(pdfIframe);

    downloadText = document.createElement('p');
    downloadText.textContent = 'Download';
    downloadText.classList.add('text', "option", "right");
    downloadText.addEventListener('click', DownloadFunc);
    document.body.appendChild(downloadText);

    threeDExperienceText = document.createElement('p');
    threeDExperienceText.textContent = '3D Experience';
    threeDExperienceText.classList.add('text', "option", "left");

    threeDExperienceText.addEventListener('click', () => {
        threeDExperienceFunc(threeDButton, pdfButton, backgroundImg, loadingText, backgroundDiv, PDFdivContainer, false);
    });
    document.body.appendChild(threeDExperienceText);


}





