from typing import Final
from telegram import Update
from telegram.ext import Application, CommandHandler, MessageHandler, filters, ContextTypes

TOKEN: Final ="6411344656:AAEpdcmQ1sm1oOb0AXA1TLuJjiwrPXiQI0k" 
BOT_USERNAME: Final = "@Societyco_bot"

#Commands
async def start_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Halooo Welcome to Society Bot")
    
async def help_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("I am just bot please start something so i can repond")
    
async def custom_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("This is custom command")
    
    
#Responses
def handle_response(text: str) -> str:
    processed: str = text.lower()
    
    if 'hello' in text:
        return "Hello There"
    
    if 'how are you' in text:
        return "I'm Good as always"
    
    if 'i love you' in text:
        return "Love you too, sweetheart"
    
    return "I dont understand"

async def handle_message(update: Update, context: ContextTypes.DEFAULT_TYPE):
    message_type: str = update.message.chat.type
    text: str = update.message.text
    
    print(f'User ({update.message.chat.id}) in {message_type}: "{text}"')

    response: str = handle_response(text)
        
    print('Bot : ', response)
    await update.message.reply_text(response)
    
    
async def error(update: Update, context: ContextTypes.DEFAULT_TYPE):
    print(f'Update{update} caused error {context.error}')
    
    
if _name_ == '_main_':
    print("Starting Bot")
    app = Application.builder().token(TOKEN).build()
    
    #Commands
    app.add_handler(CommandHandler('start', start_command))
    app.add_handler(CommandHandler('help', help_command))
    app.add_handler(CommandHandler('custom', custom_command))
    
    #For Messages
    app.add_handler(MessageHandler(filters.TEXT, handle_message))
    
    #Errors
    app.add_error_handler(error)
    
    #Polling
    print("Polling....")
    app.run_polling(poll_interval = 5)