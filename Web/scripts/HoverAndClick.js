import { PDFClick, threeDExperienceFunc } from "./Click.js";

const threeDButton = document.querySelector('.threeD');
const pdfButton = document.querySelector('.pdf');

const backgroundImg = document.querySelector('.backgroundImg');
const loadingText = document.querySelector('.text.loading');
const backgroundDiv = document.querySelector('.backgroundDiv');
const PDFdivContainer = document.querySelector('.PDFdivContainer');


threeDButton.addEventListener('mouseenter', () => {
    threeDButton.style.fontSize = '100px';
    threeDButton.style.fontWeight = '500';
    threeDButton.style.color = 'black';

    backgroundDiv.style.display = 'none';
    backgroundImg.style.display = 'block';
});

threeDButton.addEventListener('mouseleave', () => {
    threeDButton.style.fontSize = '92px';
    threeDButton.style.fontWeight = '300';
    threeDButton.style.color = '#fff8e7';

    backgroundDiv.style.display = 'block';
    backgroundImg.style.display = 'none';
});


pdfButton.addEventListener('mouseenter', () => {

    threeDButton.style.fontSize = '82px';
    threeDButton.style.webkitTextStroke = '1px #fff8e7';
    threeDButton.style.color = 'transparent';

    pdfButton.style.top = 'calc(50% + 46px)';
    pdfButton.style.fontWeight = '500';
    pdfButton.style.fontSize = "58px";
    pdfButton.style.letterSpacing = '4px';

    backgroundDiv.style.display = 'none';
    PDFdivContainer.style.display = "block";

    // Add pointer-events: none to prevent hover state conflicts
    PDFdivContainer.style.pointerEvents = 'none';
});

pdfButton.addEventListener('mouseleave', () => {

    threeDButton.style.fontSize = '92px';
    threeDButton.style.webkitTextStroke = 'initial';
    threeDButton.style.color = '#fff8e7';

    pdfButton.style.top = 'calc(50dvh + 45px)';
    pdfButton.style.fontWeight = '300';
    pdfButton.style.fontSize = "48px";
    pdfButton.style.letterSpacing = 'normal';

    PDFdivContainer.style.display = "none";
    backgroundDiv.style.display = 'block';
    // Reset pointer-events
    PDFdivContainer.style.pointerEvents = 'auto';
});

pdfButton.addEventListener('click', () => {

    PDFClick(threeDButton, pdfButton, backgroundImg, loadingText, backgroundDiv, PDFdivContainer);
});

threeDButton.addEventListener('click', () => {

    threeDExperienceFunc(threeDButton, pdfButton, backgroundImg, loadingText, backgroundDiv, PDFdivContainer, true);
});