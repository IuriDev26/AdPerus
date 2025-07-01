"use strict";
function changeIcons() {
    console.log("Iniciando changeIcons");
    const menuItems = document.querySelectorAll(".menu-list-item");
    console.log(`Encontrados ${menuItems.length} itens de menu`);
    menuItems.forEach((item, index) => {
        const defaultIcon = item.querySelector(".default-icon");
        const hoverIcon = item.querySelector(".hover-icon");
        if (defaultIcon && hoverIcon) {
            console.log(`Configurando item ${index}`);
            item.addEventListener("mousedown", () => {
                defaultIcon.style.display = "none";
                hoverIcon.style.display = "inline";
            });
            item.addEventListener("mouseup", () => {
                defaultIcon.style.display = "inline";
                hoverIcon.style.display = "none";
            });
        }
    });
}
// Função para inicializar após o Blazor
function initializeAfterBlazor() {
    if ('Blazor' in window) {
        // Se o Blazor já está carregado
        changeIcons();
    }
    else {
        // Se o Blazor ainda não está carregado, espera pelo evento
        window.addEventListener('load', () => {
            setTimeout(changeIcons, 500); // Pequeno delay para garantir que o DOM está pronto
        });
    }
}
// Inicia a função de inicialização
initializeAfterBlazor();
// Adiciona um observer para mudanças no DOM (útil para quando o Blazor atualiza a página)
const observer = new MutationObserver(() => {
    changeIcons();
});
// Observa mudanças no DOM
observer.observe(document.body, {
    childList: true,
    subtree: true
});
