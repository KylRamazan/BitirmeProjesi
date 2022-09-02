function tagItem(id, title, active) {
  return `<div class="tag-item ${(active === true) ? 'active' : ''}" data-id="${id}">${title}</div>`;
}

$('body').on("click", ".tag-item", function () {
  let id = $(this).data("id");
  let title = $(this).html();

  let targetWrapper;
  ($(this).is('.active')) ? targetWrapper = $(".tag-wrapper.unselected") : targetWrapper = $(".tag-wrapper.selected");

  targetWrapper.append(tagItem(id, title, ($(this).is('.active')) ? false : true));

  $(this).remove();
})

$('#saveTags').on("click", function () {
  let selectedTags = [];
  $.each($(".tag-item.active"), function (index, value) {
  })

  if (!selectedTags.length) {
    return alert("Lütfen en az bir tag seçiniz.");
  }

  $.ajax({
    url: "/api/Tag/SaveTags",
    type: "POST",
    data: {
      "tags": selectedTags
    },
    success: function (data) {
      if (data.success) {
        alert("Kayıt başarılı");
      } else {
        alert("Kayıt başarısız");
      }
    },
    error: function (data) {
      alert("Hata oluştu");
    }
  })
});

