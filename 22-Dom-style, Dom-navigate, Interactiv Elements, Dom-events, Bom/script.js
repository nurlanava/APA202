const app = document.getElementById("app");

const card = document.createElement("div");
card.style.width = "350px";
card.style.borderRadius = "15px";
card.style.overflow = "hidden";
card.style.boxShadow = "0 4px 12px rgba(0,0,0,0.2)";
card.style.fontFamily = "Arial";
card.style.margin = "20px auto";
card.style.background = "#fff";

const imgBox = document.createElement("div");
imgBox.style.position = "relative";

const img = document.createElement("img");
img.src = "https://images.unsplash.com/photo-1568605114967-8130f3a36994";
img.style.width = "100%";

const heart = document.createElement("div");
heart.innerHTML = "♡";
heart.style.position = "absolute";
heart.style.top = "10px";
heart.style.right = "15px";
heart.style.fontSize = "24px";
heart.style.color = "white";
heart.style.cursor = "pointer";

let liked = false;
heart.addEventListener("click", () => {
  liked = !liked;
  heart.innerHTML = liked ? "❤️" : "♡";
});

imgBox.appendChild(img);
imgBox.appendChild(heart);

const content = document.createElement("div");
content.style.padding = "15px";

const title = document.createElement("p");
title.textContent = "DETACHED HOUSE • 5Y OLD";
title.style.color = "gray";
title.style.fontWeight = "bold";

const price = document.createElement("h2");
price.textContent = "$750,000";

const address = document.createElement("p");
address.textContent = "742 Evergreen Terrace";
address.style.color = "gray";

const info = document.createElement("div");
info.style.display = "flex";
info.style.justifyContent = "space-between";
info.style.marginTop = "10px";

const bed = document.createElement("span");
bed.textContent = "🛏 3 Bedrooms";

const bath = document.createElement("span");
bath.textContent = "🛁 2 Bathrooms";

info.appendChild(bed);
info.appendChild(bath);

const realtorBox = document.createElement("div");
realtorBox.style.display = "flex";
realtorBox.style.alignItems = "center";
realtorBox.style.marginTop = "15px";

const avatar = document.createElement("img");
avatar.src = "https://randomuser.me/api/portraits/women/44.jpg";
avatar.style.width = "40px";
avatar.style.height = "40px";
avatar.style.borderRadius = "50%";
avatar.style.marginRight = "10px";

const realtorInfo = document.createElement("div");

const name = document.createElement("p");
name.textContent = "Tiffany Heffner";
name.style.fontWeight = "bold";

const phone = document.createElement("p");
phone.textContent = "(555) 555-4321";
phone.style.color = "gray";
phone.style.fontSize = "14px";

realtorInfo.appendChild(name);
realtorInfo.appendChild(phone);

realtorBox.appendChild(avatar);
realtorBox.appendChild(realtorInfo);

card.addEventListener("click", () => {
  card.style.transform = "scale(1.02)";
  setTimeout(() => {
    card.style.transform = "scale(1)";
  }, 150);
});

card.addEventListener("mouseover", () => {
  card.style.boxShadow = "0 8px 20px rgba(0,0,0,0.3)";
});
card.addEventListener("mouseout", () => {
  card.style.boxShadow = "0 4px 12px rgba(0,0,0,0.2)";
});

content.appendChild(title);
content.appendChild(price);
content.appendChild(address);
content.appendChild(info);
content.appendChild(realtorBox);

card.appendChild(imgBox);
card.appendChild(content);

app.appendChild(card);